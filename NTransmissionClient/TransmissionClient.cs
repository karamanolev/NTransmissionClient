using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using NTransmissionClient.Model;

namespace NTransmissionClient
{

    /// <summary>
    /// Based on Transmission documentation and code located at:
    /// https://trac.transmissionbt.com/browser/trunk/extras/rpc-spec.txt
    /// https://trac.transmissionbt.com/browser/trunk/libtransmission/transmission.h
    /// </summary>
    public class TransmissionClient : IDisposable
    {
        private string username, password;
        private HttpClient client;
        private JsonSerializer serializer;
        private string sessionId;

        public string AccessUrl { get; set; }

        public string Username
        {
            get { return this.username; }
            set
            {
                this.username = value;
                this.RecreateClient();
            }
        }

        public string Password
        {
            get { return this.password; }
            set
            {
                this.password = value;
                this.RecreateClient();
            }
        }

        public TransmissionClient(string fullAccessUrl)
        {
            this.Username = "transmission";

            this.serializer = new JsonSerializer();
            this.serializer.NullValueHandling = NullValueHandling.Ignore;

            this.AccessUrl = fullAccessUrl;
        }

        public async Task SessionClose()
        {
            await this.ExecuteMethodChecked(new TransmissionRequest()
            {
                Method = GetAttributeOfType<DisplayAttribute, Methods>(Methods.SessionClose).Description,
            });
        }

        public Task SessionCloseAsync()
        {
            return Task.Run(() => this.SessionClose());
        }

        public async Task<SessionStatistics> GetSessionStatistics()
        {
            var request = new TransmissionRequest()
            {
                Method = GetAttributeOfType<DisplayAttribute, Methods>(Methods.SessionStats).Description,
            };
            return await this.ExecuteMethodChecked<SessionStatistics>(request);
        }

        public async Task<TorrentAddResponse> AddTorrent(TorrentAddRequest addRequest)
        {
            var request = new TransmissionRequest()
            {
                Method = GetAttributeOfType<DisplayAttribute, Methods>(Methods.TorrentAdd).Description,
                Arguments = addRequest
            };
            return await this.ExecuteMethodChecked<TorrentAddResponse>(request);
        }

        public async Task RemoveTorrent(bool deleteLocalData = false)
        {
            await this.RemoveTorrentInternal(null, deleteLocalData);
        }

        public async Task RemoveTorrent(int[] ids, bool deleteLocalData = false)
        {
            await this.RemoveTorrentInternal(ids, deleteLocalData);
        }

        public async Task RemoveTorrent(int id, bool deleteLocalData = false)
        {
            await this.RemoveTorrentInternal(id, deleteLocalData);
        }

        public async Task<TorrentGetResponse> GetTorrentFields(TorrentFields[] fields = null)
        {
            return await this.GetTorrentFieldsInternal(null, fields);
        }

        public async Task<TorrentGetResponse> GetTorrentFields(int[] ids, TorrentFields[] fields = null)
        {
            return await this.GetTorrentFieldsInternal(ids, fields);
        }

        public async Task<TorrentGetResponse> GetTorrentFields(int id, TorrentFields[] fields = null)
        {
            return await this.GetTorrentFieldsInternal(id, fields);
        }

        private void RecreateClient()
        {
            var clientHandler = new HttpClientHandler();
            clientHandler.Credentials = new NetworkCredential(this.username, this.password);
            this.client = new HttpClient(clientHandler, true);
        }

        private async Task RemoveTorrentInternal(object ids, bool deleteLocalData)
        {
            var request = new TransmissionRequest()
            {
                Method = GetAttributeOfType<DisplayAttribute, Methods>(Methods.TorrentRemove).Description,
                Arguments = new TorrentDeleteRequest()
                {
                    Ids = ids,
                    DeleteLocalData = deleteLocalData
                }
            };
            await this.ExecuteMethodChecked(request);
        }

        private async Task<TorrentGetResponse> GetTorrentFieldsInternal(object ids, TorrentFields[] fields)
        {
            var readableFields = fields ?? GetAllEnumItems<TorrentFields>();

            var request = new TransmissionRequest()
            {
                Method = GetAttributeOfType<DisplayAttribute, Methods>(Methods.TorrentGet).Description,
                Arguments = new TorrentGetRequest()
                {
                    Ids = ids,
                    Fields = GetDisplayAttributeDescriptions(readableFields)
                }
            };
            return await this.ExecuteMethodChecked<TorrentGetResponse>(request);
        }

        private async Task<T> DeserializeFromJson<T>(HttpContent content)
        {
            using (var responseStream = await content.ReadAsStreamAsync())
            {
                using (var reader = new StreamReader(responseStream))
                {
                    using (var jsonReader = new JsonTextReader(reader))
                    {
                        return this.serializer.Deserialize<T>(jsonReader);
                    }
                }
            }
        }

        private async Task<T> ExecuteMethod<T>(TransmissionRequest requestData)
        {
            var content = new JsonPushContent(this.serializer, requestData);

            if (this.sessionId != null)
            {
                content.Headers.Add("X-Transmission-Session-Id", this.sessionId);
            }

            using (var response = await this.client.PostAsync(this.AccessUrl, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await this.DeserializeFromJson<T>(response.Content);
                }
                else
                {
                    if (response.StatusCode == HttpStatusCode.Conflict)
                    {
                        // Set session and rerurn
                        this.sessionId = response.Headers.GetValues("X-Transmission-Session-Id").First();
                    }
                    else
                    {
                        response.EnsureSuccessStatusCode();
                    }
                }
            }
            return await this.ExecuteMethod<T>(requestData);
        }

        private async Task<T> ExecuteMethodChecked<T>(TransmissionRequest request)
        {
            var response = await this.ExecuteMethod<TransmissionResponse<T>>(request);
            if (response.Result != "success")
            {
                throw new TransmissionException(response.Result);
            }
            return response.Arguments;
        }

        private async Task ExecuteMethodChecked(TransmissionRequest request)
        {
            var response = await this.ExecuteMethod<TransmissionResponse>(request);
            if (response.Result != "success")
            {
                throw new TransmissionException(response.Result);
            }
        }

        private static T[] GetAllEnumItems<T>()
        {
            return (T[])Enum.GetValues(typeof(T));
        }

        private static T GetAttributeOfType<T, U>(U typeVal) where T : Attribute
        {
            var typeInfo = typeVal.GetType().GetTypeInfo();
            var memberInfo = typeInfo.DeclaredMembers.First(x => x.Name == typeVal.ToString());
            return memberInfo.GetCustomAttribute<T>();
        }

        private static string[] GetDisplayAttributeDescriptions<T>(T[] typeVal)
        {
            return typeVal.Select(x => GetAttributeOfType<DisplayAttribute, T>(x).Description).ToArray();
        }

        public void Dispose()
        {
            if (this.client != null)
            {
                this.client.Dispose();
                this.client = null;
            }
        }
    }
}
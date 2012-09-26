﻿using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    public class TransmissionClient
    {
        private JsonSerializer serializer;
        private string sessionId;

        public string Username { get; set; }
        public string Password { get; set; }
        public string AccessUrl { get; set; }

        public TransmissionClient(string fullAccessUrl)
        {
            this.serializer = new JsonSerializer();
            this.serializer.NullValueHandling = NullValueHandling.Ignore;

            this.AccessUrl = fullAccessUrl;
        }

        private async Task<T> ExecuteMethod<T>(TransmissionRequest requestData)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(AccessUrl);
            if (this.sessionId != null)
            {
                request.Headers["X-Transmission-Session-Id"] = this.sessionId;
            }
            if (this.Username != null && this.Password != null)
            {
                request.Credentials = new NetworkCredential(this.Username, this.Password);
            }
            request.Method = "POST";

            using (Stream requestStream = await request.GetRequestStreamAsync())
            {
                using (StreamWriter writer = new StreamWriter(requestStream))
                {
                    serializer.Serialize(writer, requestData);
                }
            }

            try
            {
                using (var response = (HttpWebResponse)await request.GetResponseAsync())
                {

                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            using (JsonTextReader jsonReader = new JsonTextReader(reader))
                            {
                                return this.serializer.Deserialize<T>(jsonReader);
                            }
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                using (var response = (HttpWebResponse)ex.Response)
                {
                    if (response.StatusCode == HttpStatusCode.Conflict)
                    {
                        // Set session and rerurn
                        this.sessionId = response.Headers["X-Transmission-Session-Id"];
                    }
                    else
                    {
                        throw ex;
                    }
                }
            }

            return await this.ExecuteMethod<T>(requestData);
        }

        private async Task<T> ExecuteMethodChecked<T>(TransmissionRequest request)
        {
            TransmissionResponse<T> response = await this.ExecuteMethod<TransmissionResponse<T>>(request);
            if (response.Result == "success")
            {
                return response.Arguments;
            }
            else
            {
                throw new TransmissionException(response.Result);
            }
        }

        private async Task ExecuteMethodChecked(TransmissionRequest request)
        {
            TransmissionResponse response = await this.ExecuteMethod<TransmissionResponse>(request);
            if (response.Result != "success")
            {
                throw new TransmissionException(response.Result);
            }
        }

        public async Task SessionClose()
        {
            await this.ExecuteMethodChecked(new TransmissionRequest()
            {
                Method = "session-close"
            });
        }

        public Task SessionCloseAsync()
        {
            return Task.Run(() => this.SessionClose());
        }

        public async Task<SessionStatistics> GetSessionStatistics()
        {
            TransmissionRequest request = new TransmissionRequest()
            {
                Method = "session-stats"
            };
            return await this.ExecuteMethodChecked<SessionStatistics>(request);
        }

        public async Task<TorrentAddResponse> AddTorrent(TorrentAddRequest addRequest)
        {
            TransmissionRequest request = new TransmissionRequest()
            {
                Method = "torrent-add",
                Arguments = addRequest
            };
            return await this.ExecuteMethodChecked<TorrentAddResponse>(request);
        }

        private async Task RemoveTorrentInternal(object ids, bool deleteLocalData)
        {
            TransmissionRequest request = new TransmissionRequest()
            {
                Method = "torrent-remove",
                Arguments = new TorrentDeleteRequest()
                {
                    Ids = ids,
                    DeleteLocalData = deleteLocalData
                }
            };
            await this.ExecuteMethodChecked(request);
        }

        public async Task RemoveTorrent(bool deleteLocalData = false)
        {
            await this.RemoveTorrentInternal(null, deleteLocalData);
        }

        public async Task RemoveTorrent(string[] ids, bool deleteLocalData = false)
        {
            await this.RemoveTorrentInternal(ids, deleteLocalData);
        }

        public async Task RemoveTorrent(int[] ids, bool deleteLocalData = false)
        {
            await this.RemoveTorrentInternal(ids, deleteLocalData);
        }

        public async Task RemoveTorrent(string id, bool deleteLocalData = false)
        {
            await this.RemoveTorrentInternal(id, deleteLocalData);
        }

        public async Task RemoveTorrent(int id, bool deleteLocalData = false)
        {
            await this.RemoveTorrentInternal(id, deleteLocalData);
        }

        private async Task<TorrentGetResponse> GetTorrentFieldsInternal(object ids, string[] fields)
        {
            TransmissionRequest request = new TransmissionRequest()
            {
                Method = "torrent-get",
                Arguments = new TorrentGetRequest()
                {
                    Ids = ids,
                    Fields = fields ?? TorrentFields.AllFields
                }
            };
            return await this.ExecuteMethodChecked<TorrentGetResponse>(request);
        }

        public async Task<TorrentGetResponse> GetTorrentFields(string[] fields = null)
        {
            return await this.GetTorrentFieldsInternal(null, fields);
        }

        public async Task<TorrentGetResponse> GetTorrentFields(string[] ids, string[] fields = null)
        {
            return await this.GetTorrentFieldsInternal(ids, fields);
        }

        public async Task<TorrentGetResponse> GetTorrentFields(int[] ids, string[] fields = null)
        {
            return await this.GetTorrentFieldsInternal(ids, fields);
        }

        public async Task<TorrentGetResponse> GetTorrentFields(string id, string[] fields = null)
        {
            return await this.GetTorrentFieldsInternal(id, fields);
        }

        public async Task<TorrentGetResponse> GetTorrentFields(int id, string[] fields = null)
        {
            return await this.GetTorrentFieldsInternal(id, fields);
        }
    }
}
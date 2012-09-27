using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    class JsonPushContent : HttpContent
    {
        private JsonSerializer serializer;
        private object content;

        public JsonPushContent(JsonSerializer serializer, object content)
        {
            this.serializer = serializer;
            this.content = content;
        }

        protected override async Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context)
        {
            await Task.Run(() =>
            {
                using (StreamWriter writer = new StreamWriter(stream, new UTF8Encoding(false), 4096, true))
                {
                    this.serializer.Serialize(writer, this.content);
                }
            });
        }

        protected override bool TryComputeLength(out long length)
        {
            length = -1;
            return false;
        }
    }
}

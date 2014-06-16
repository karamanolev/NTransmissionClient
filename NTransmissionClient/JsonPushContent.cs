using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace NTransmissionClient
{
    internal class JsonPushContent : HttpContent
    {
        private JsonSerializer serializer;
        private object content;

        public JsonPushContent(JsonSerializer serializer, object content)
        {
            this.serializer = serializer;
            this.content = content;
        }

        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            await Task.Run(() =>
            {
                using (var writer = new StreamWriter(stream, new UTF8Encoding(false), 4096, true))
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
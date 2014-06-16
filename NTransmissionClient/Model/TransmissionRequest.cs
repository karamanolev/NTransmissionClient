using Newtonsoft.Json;
using System;
using System.Linq;

namespace NTransmissionClient.Model
{
    public class TransmissionRequest
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("arguments")]
        public object Arguments { get; set; }
    }
}
using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    class TransmissionResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    class TransmissionResponse<T> : TransmissionResponse
    {
        [JsonProperty("arguments")]
        public T Arguments { get; set; }
    }
}

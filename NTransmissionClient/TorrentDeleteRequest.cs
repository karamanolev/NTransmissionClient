using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    class TorrentDeleteRequest
    {
        [JsonProperty("ids")]
        public object Ids { get; set; }

        [JsonProperty("delete-local-data")]
        public bool? DeleteLocalData { get; set; }
    }
}

using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    class TorrentGetRequest
    {
        [JsonProperty("ids")]
        public object Ids { get; set; }

        [JsonProperty("fields")]
        public string[] Fields { get; set; }
    }
}

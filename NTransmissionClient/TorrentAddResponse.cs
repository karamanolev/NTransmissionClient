using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    public class TorrentAddResponse
    {
        [JsonProperty("hashString")]
        public string HashString { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

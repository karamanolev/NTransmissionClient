using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    public class TorrentInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

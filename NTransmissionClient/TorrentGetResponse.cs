using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    public class TorrentGetResponse
    {
        [JsonProperty("torrents")]
        public TorrentInfo[] Torrents { get; set; }

        [JsonProperty("removed")]
        public object[] Removed { get; set; }
    }
}

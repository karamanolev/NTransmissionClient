using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    public class TorrentAddResponse
    {
        [JsonProperty("torrent-added")]
        public TorrentAddInfo TorrentAdded { get; set; }
    }
}

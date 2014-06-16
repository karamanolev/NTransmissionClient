using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    public class TorrentAddResponse
    {
        [JsonProperty("torrent-added")]
        public TorrentAddInfo TorrentAdded { get; set; }
    }
}
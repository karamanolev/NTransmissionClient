using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    public class SessionStatistics
    {
        [JsonProperty("activeTorrentCount")]
        public long ActiveTorrentCount { get; set; }

        [JsonProperty("downloadSpeed")]
        public long DownloadSpeed { get; set; }

        [JsonProperty("pausedTorrentCount")]
        public long PausedTorrentCount { get; set; }

        [JsonProperty("torrentCount")]
        public long TorrentCount { get; set; }

        [JsonProperty("uploadSpeed")]
        public long UploadSpeed { get; set; }

        [JsonProperty("cumulative-stats")]
        public TrSessionStats CumulativeStats { get; set; }

        [JsonProperty("current-stats")]
        public TrSessionStats CurrentStats { get; set; }
    }
}

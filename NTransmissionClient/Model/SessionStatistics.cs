using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <example>
    ///string                     | value type
    ///---------------------------+-------------------------------------------------
    ///"activeTorrentCount"       | number
    ///"downloadSpeed"            | number
    ///"pausedTorrentCount"       | number
    ///"torrentCount"             | number
    ///"uploadSpeed"              | number
    ///---------------------------+-------------------------------+
    ///"cumulative-stats"         | object, containing:           |
    ///                           +------------------+------------+
    ///                           | uploadedBytes    | number     | tr_session_stats
    ///                           | downloadedBytes  | number     | tr_session_stats
    ///                           | filesAdded       | number     | tr_session_stats
    ///                           | sessionCount     | number     | tr_session_stats
    ///                           | secondsActive    | number     | tr_session_stats
    ///---------------------------+-------------------------------+
    ///"current-stats"            | object, containing:           |
    ///                           +------------------+------------+
    ///                           | uploadedBytes    | number     | tr_session_stats
    ///                           | downloadedBytes  | number     | tr_session_stats
    ///                           | filesAdded       | number     | tr_session_stats
    ///                           | sessionCount     | number     | tr_session_stats
    ///                           | secondsActive    | number     | tr_session_stats
    /// </example>
    public class SessionStatistics
    {
        [JsonProperty("activeTorrentCount")]
        public long? ActiveTorrentCount { get; set; }

        [JsonProperty("downloadSpeed")]
        public long? DownloadSpeed { get; set; }

        [JsonProperty("pausedTorrentCount")]
        public long? PausedTorrentCount { get; set; }

        [JsonProperty("torrentCount")]
        public long? TorrentCount { get; set; }

        [JsonProperty("uploadSpeed")]
        public long? UploadSpeed { get; set; }

        [JsonProperty("cumulative-stats")]
        public TrSessionStats CumulativeStats { get; set; }

        [JsonProperty("current-stats")]
        public TrSessionStats CurrentStats { get; set; }
    }
}
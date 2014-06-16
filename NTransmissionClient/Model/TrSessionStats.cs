using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <example>
    ///---------------------------+-------------------------------+
    ///"stats"                    | object, containing:           |
    ///                           +------------------+------------+
    ///                           | uploadedBytes    | number     | tr_session_stats
    ///                           | downloadedBytes  | number     | tr_session_stats
    ///                           | filesAdded       | number     | tr_session_stats
    ///                           | sessionCount     | number     | tr_session_stats
    ///                           | secondsActive    | number     | tr_session_stats
    ///---------------------------+-------------------------------+
    /// </example>
    public class TrSessionStats
    {
        [JsonProperty("uploadedBytes")]
        public long? UploadedBytes { get; set; }

        [JsonProperty("downloadedBytes")]
        public long? DownloadedBytes { get; set; }

        [JsonProperty("filesAdded")]
        public long? FilesAdded { get; set; }

        [JsonProperty("sessionCount")]
        public long? SessionCount { get; set; }

        [JsonProperty("secondsActive")]
        public long? SecondsActive { get; set; }
    }
}
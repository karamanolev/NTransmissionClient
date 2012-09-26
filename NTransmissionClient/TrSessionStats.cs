using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    public class TrSessionStats
    {
        [JsonProperty("uploadedBytes")]
        public long UploadedBytes { get; set; }

        [JsonProperty("downloadedBytes")]
        public long DownloadedBytes { get; set; }

        [JsonProperty("filesAdded")]
        public long FilesAdded { get; set; }

        [JsonProperty("sessionCount")]
        public long SessionCount { get; set; }

        [JsonProperty("secondsActive")]
        public long SecondsActive { get; set; }
    }
}

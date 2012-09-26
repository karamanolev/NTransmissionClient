using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    public class TorrentAddRequest
    {
        [JsonProperty("cookies")]
        public string Cookies { get; set; }

        [JsonProperty("download-dir")]
        public string DownloadDir { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; private set; }

        [JsonProperty("metainfo")]
        public string MetaInfo { get; private set; }

        [JsonProperty("paused")]
        public bool? Paused { get; set; }

        [JsonProperty("peer-limit")]
        public int? PeerLimit { get; set; }

        [JsonProperty("bandwidthPriority")]
        public int? BandwidthPriority { get; set; }

        [JsonProperty("files-wanted")]
        public int[] FilesWanted { get; set; }

        [JsonProperty("files-unwanted")]
        public int[] FilesUnwanted { get; set; }

        [JsonProperty("priority-high")]
        public int[] PriorityHigh { get; set; }

        [JsonProperty("priority-normal")]
        public int[] PriorityNormal { get; set; }

        [JsonProperty("priority-low")]
        public int[] PriorityLow { get; set; }

        public TorrentAddRequest(byte[] bytes)
        {
            this.MetaInfo = Convert.ToBase64String(bytes);
        }

        public TorrentAddRequest(string filename)
        {
            this.Filename = filename;
        }
    }
}

using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient
{
    public class TorrentInfo
    {

        [JsonProperty("activityDate")]
        public string ActivityDate { get; set; }

        [JsonProperty("addedDate")]
        public string AddedDate { get; set; }

        [JsonProperty("bandwidthPriority")]
        public string BandwidthPriority { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("corruptEver")]
        public string CorruptEver { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("desiredAvailable")]
        public string DesiredAvailable { get; set; }

        [JsonProperty("doneDate")]
        public string DoneDate { get; set; }

        [JsonProperty("downloadDir")]
        public string DownloadDir { get; set; }

        [JsonProperty("downloadedEver")]
        public string DownloadedEver { get; set; }

        [JsonProperty("downloadLimitc")]
        public string DownloadLimitc { get; set; }

        [JsonProperty("downloadLimited")]
        public string DownloadLimited { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorString")]
        public string ErrorString { get; set; }

        [JsonProperty("eta")]
        public string Eta { get; set; }

        //[JsonProperty("files")]
        //public string Files { get; set; }

        //[JsonProperty("fileStats")]
        //public string FileStats { get; set; }

        [JsonProperty("hashString")]
        public string HashString { get; set; }

        [JsonProperty("haveUnchecked")]
        public string HaveUnchecked { get; set; }

        [JsonProperty("haveValid")]
        public string HaveValid { get; set; }

        [JsonProperty("honorsSessionLimits")]
        public string HonorsSessionLimits { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isFinished")]
        public string IsFinished { get; set; }

        [JsonProperty("isPrivate")]
        public string IsPrivate { get; set; }

        [JsonProperty("isStalled")]
        public string IsStalled { get; set; }

        [JsonProperty("leftUntilDone")]
        public string LeftUntilDone { get; set; }

        [JsonProperty("magnetLink")]
        public string MagnetLink { get; set; }

        [JsonProperty("manualAnnounceTime")]
        public string ManualAnnounceTime { get; set; }

        [JsonProperty("maxConnectedPeers")]
        public string MaxConnectedPeers { get; set; }

        [JsonProperty("metadataPercentComplete")]
        public string MetadataPercentComplete { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("peer-limit")]
        public string PeerLimit { get; set; }

        //[JsonProperty("peers")]
        //public string Peers { get; set; }

        [JsonProperty("peersConnected")]
        public string PeersConnected { get; set; }

        //[JsonProperty("peersFrom")]
        //public string PeersFrom { get; set; }

        [JsonProperty("peersGettingFromUs")]
        public string PeersGettingFromUs { get; set; }

        [JsonProperty("peersSendingToUs")]
        public string PeersSendingToUs { get; set; }

        [JsonProperty("percentDone")]
        public string PercentDone { get; set; }

        [JsonProperty("pieces")]
        public string Pieces { get; set; }

        [JsonProperty("pieceCount")]
        public string PieceCount { get; set; }

        [JsonProperty("pieceSize")]
        public string PieceSize { get; set; }

        //[JsonProperty("priorities")]
        //public string Priorities { get; set; }

        [JsonProperty("queuePosition")]
        public string QueuePosition { get; set; }

        /// <summary>
        /// (B/s)
        /// </summary>
        [JsonProperty("rateDownload")]
        public string RateDownload { get; set; }

        /// <summary>
        /// (B/s)
        /// </summary>
        [JsonProperty("rateUpload")]
        public string RateUpload { get; set; }

        [JsonProperty("recheckProgress")]
        public string RecheckProgress { get; set; }

        [JsonProperty("secondsDownloading")]
        public string SecondsDownloading { get; set; }

        [JsonProperty("secondsSeeding")]
        public string SecondsSeeding { get; set; }

        [JsonProperty("seedIdleLimit")]
        public string SeedIdleLimit { get; set; }

        [JsonProperty("seedIdleMode")]
        public string SeedIdleMode { get; set; }

        [JsonProperty("seedRatioLimit")]
        public string SeedRatioLimit { get; set; }

        [JsonProperty("seedRatioMode")]
        public string SeedRatioMode { get; set; }

        [JsonProperty("sizeWhenDone")]
        public string SizeWhenDone { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        //[JsonProperty("trackers")]
        //public string Trackers { get; set; }

        //[JsonProperty("trackerStats")]
        //public string TrackerStats { get; set; }

        [JsonProperty("totalSize")]
        public string TotalSize { get; set; }

        [JsonProperty("torrentFile")]
        public string TorrentFile { get; set; }

        [JsonProperty("uploadedEver")]
        public string UploadedEver { get; set; }

        [JsonProperty("uploadLimit")]
        public string UploadLimit { get; set; }

        [JsonProperty("uploadLimited")]
        public string UploadLimited { get; set; }

        [JsonProperty("uploadRatio")]
        public string UploadRatio { get; set; }

        //[JsonProperty("wanted")]
        //public string Wanted { get; set; }

        //[JsonProperty("webseeds")]
        //public string Webseeds { get; set; }

        [JsonProperty("webseedsSendingToUs")]
        public string WebseedsSendingToUs { get; set; }

    }
}

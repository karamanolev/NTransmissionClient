using System;
using System.Linq;

namespace NTransmissionClient
{
    public class TorrentFields
    {
        public static readonly string[] AllFields = new string[] { "activityDate", "addedDate", "bandwidthPriority", "comment", "corruptEver", "creator", "dateCreated", "desiredAvailable", "doneDate", "downloadDir", "downloadedEver", "downloadLimitc", "downloadLimited", "error", "errorString", "eta", "files", "fileStats", "hashString", "haveUnchecked", "haveValid", "honorsSessionLimits", "id", "isFinished", "isPrivate", "isStalled", "leftUntilDone", "magnetLink", "manualAnnounceTime", "maxConnectedPeers", "metadataPercentComplete", "name", "peer-limit", "peers", "peersConnected", "peersFrom", "peersGettingFromUs", "peersSendingToUs", "percentDone", "pieces", "pieceCount", "pieceSize", "priorities", "queuePosition", "rateDownload(B/s)", "rateUpload(B/s)", "recheckProgress", "secondsDownloading", "secondsSeeding", "seedIdleLimit", "seedIdleMode", "seedRatioLimit", "seedRatioMode", "sizeWhenDone", "startDate", "status", "trackers", "trackerStats", "totalSize", "torrentFile", "uploadedEver", "uploadLimit", "uploadLimited", "uploadRatio", "wanted", "webseeds", "webseedsSendingToUs" };

        public const string ActivityDate = "activityDate";
        public const string AddedDate = "addedDate";
        public const string BandwidthPriority = "bandwidthPriority";
        public const string Comment = "comment";
        public const string CorruptEver = "corruptEver";
        public const string Creator = "creator";
        public const string DateCreated = "dateCreated";
        public const string DesiredAvailable = "desiredAvailable";
        public const string DoneDate = "doneDate";
        public const string DownloadDir = "downloadDir";
        public const string DownloadedEver = "downloadedEver";
        public const string DownloadLimitc = "downloadLimitc";
        public const string DownloadLimited = "downloadLimited";
        public const string Error = "error";
        public const string ErrorString = "errorString";
        public const string Eta = "eta";
        public const string Files = "files";
        public const string FileStats = "fileStats";
        public const string HashString = "hashString";
        public const string HaveUnchecked = "haveUnchecked";
        public const string HaveValid = "haveValid";
        public const string HonorsSessionLimits = "honorsSessionLimits";
        public const string Id = "id";
        public const string IsFinished = "isFinished";
        public const string IsPrivate = "isPrivate";
        public const string IsStalled = "isStalled";
        public const string LeftUntilDone = "leftUntilDone";
        public const string MagnetLink = "magnetLink";
        public const string ManualAnnounceTime = "manualAnnounceTime";
        public const string MaxConnectedPeers = "maxConnectedPeers";
        public const string MetadataPercentComplete = "metadataPercentComplete";
        public const string Name = "name";
        public const string PeerLimit = "peer-limit";
        public const string Peers = "peers";
        public const string PeersConnected = "peersConnected";
        public const string PeersFrom = "peersFrom";
        public const string PeersGettingFromUs = "peersGettingFromUs";
        public const string PeersSendingToUs = "peersSendingToUs";
        public const string PercentDone = "percentDone";
        public const string Pieces = "pieces";
        public const string PieceCount = "pieceCount";
        public const string PieceSize = "pieceSize";
        public const string Priorities = "priorities";
        public const string QueuePosition = "queuePosition";
        public const string RateDownloadBs = "rateDownload (B/s)";
        public const string RateUploadBs = "rateUpload (B/s)";
        public const string RecheckProgress = "recheckProgress";
        public const string SecondsDownloading = "secondsDownloading";
        public const string SecondsSeeding = "secondsSeeding";
        public const string SeedIdleLimit = "seedIdleLimit";
        public const string SeedIdleMode = "seedIdleMode";
        public const string SeedRatioLimit = "seedRatioLimit";
        public const string SeedRatioMode = "seedRatioMode";
        public const string SizeWhenDone = "sizeWhenDone";
        public const string StartDate = "startDate";
        public const string Status = "status";
        public const string Trackers = "trackers";
        public const string TrackerStats = "trackerStats";
        public const string TotalSize = "totalSize";
        public const string TorrentFile = "torrentFile";
        public const string UploadedEver = "uploadedEver";
        public const string UploadLimit = "uploadLimit";
        public const string UploadLimited = "uploadLimited";
        public const string UploadRatio = "uploadRatio";
        public const string Wanted = "wanted";
        public const string Webseeds = "webseeds";
        public const string WebseedsSendingToUs = "webseedsSendingToUs";
    }
}

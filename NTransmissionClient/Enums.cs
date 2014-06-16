using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTransmissionClient
{
    public enum TorrentFields
    {
        /// <summary>
        /// The last time we uploaded or downloaded piece data on this torrent.
        /// </summary>
        [Display(Description = "activityDate")]
        ActivityDate,

        /// <summary>
        /// When the torrent was first added.
        /// </summary>
        [Display(Description = "addedDate")]
        AddedDate,

        /// <summary>
        /// Bandwidth priority. Low (-1), Normal (0) or High (1).
        /// </summary>
        [Display(Description = "bandwidthPriority")]
        BandwidthPriority,

        /// <summary>
        /// Torrent comment.
        /// </summary>
        [Display(Description = "comment")]
        Comment,

        /// <summary>
        /// Byte count of all the corrupt data you've ever downloaded for this torrent.
        /// If you're on a poisoned torrent, this number can grow very large.
        /// </summary>
        [Display(Description = "corruptEver")]
        CorruptEver,

        /// <summary>
        /// Torrent creator.
        /// </summary>
        [Display(Description = "creator")]
        Creator,

        /// <summary>
        /// Torrent creation date.
        /// </summary>
        [Display(Description = "dateCreated")]
        DateCreated,

        /// <summary>
        /// Byte count of all the piece data we want and don't have yet, but that a connected peer does have.
        /// </summary>
        [Display(Description = "desiredAvailable")]
        DesiredAvailable,

        /// <summary>
        /// The date when the torrent finished downloading.
        /// </summary>
        [Display(Description = "doneDate")]
        DoneDate,

        /// <summary>
        /// The directory path where the torrent is downloaded to.
        /// </summary>
        [Display(Description = "downloadDir")]
        DownloadDir,

        /// <summary>
        /// Byte count of all the non-corrupt data you've ever downloaded for this torrent.
        /// If you deleted the files and downloaded a second time, this will be 2*totalSize..
        /// </summary>
        [Display(Description = "downloadedEver")]
        DownloadedEver,

        /// <summary>
        /// Download limit in Kbps.
        /// </summary>
        [Display(Description = "downloadLimit")]
        DownloadLimit,

        /// <summary>
        /// Download limit is enabled.
        /// </summary>
        [Display(Description = "downloadLimited")]
        DownloadLimited,

        /// <summary>
        /// Number of downloaders.
        /// </summary>
        [Display(Description = "downloaders")]
        Downloaders,

        /// <summary>
        /// Defines what kind of text is in errorString.
        /// </summary>
        [Display(Description = "error")]
        Error,

        /// <summary>
        /// A warning or error message regarding the torrent.
        /// </summary>
        [Display(Description = "errorString")]
        ErrorString,

        /// <summary>
        /// If downloading, estimated number of seconds left until the torrent is done.
        /// If seeding, estimated number of seconds left until seed ratio is reached.
        /// -1 means not available and -2 means unknown.
        /// </summary>
        [Display(Description = "eta")]
        Eta,

        /// <summary>
        /// If seeding, number of seconds left until the idle time limit is reached.
        /// </summary>
        [Display(Description = "etaIdle")]
        EtaIdle,

        /// <summary>
        /// Array of file object containing key, bytesCompleted, length and name.
        /// </summary>
        [Display(Description = "files")]
        Files,

        /// <summary>
        /// Array of file statistics containing bytesCompleted, wanted and priority.
        /// </summary>
        [Display(Description = "fileStats")]
        FileStats,

        /// <summary>
        /// Hashstring unique for the torrent even between sessions.
        /// </summary>
        [Display(Description = "hashString")]
        HashString,

        /// <summary>
        /// Byte count of all the partial piece data we have for this torrent.
        /// As pieces become complete, this value may decrease as portions of it are moved to `corrupt' or `haveValid'.
        /// </summary>
        [Display(Description = "haveUnchecked")]
        HaveUnchecked,

        /// <summary>
        /// Number of bytes of checksum verified data.
        /// </summary>
        [Display(Description = "haveValid")]
        HaveValid,

        /// <summary>
        /// True if session upload limits are honored
        /// </summary>
        [Display(Description = "honorsSessionLimits")]
        HonorsSessionLimits,

        /// <summary>
        /// The torrent's unique Id.
        /// </summary>
        [Display(Description = "id")]
        Id,

        /// <summary>
        /// True if the torrent is finished. Downloaded and seeded.
        /// </summary>
        [Display(Description = "isFinished")]
        IsFinished,

        /// <summary>
        /// True if the torrent is private.
        /// </summary>
        [Display(Description = "isPrivate")]
        IsPrivate,

        /// <summary>
        /// True if the torrent has stalled (been idle for a long time).
        /// </summary>
        [Display(Description = "isStalled")]
        IsStalled,

        /// <summary>
        /// Byte count of how much data is left to be downloaded until we've got all the pieces that we want.
        /// </summary>
        [Display(Description = "leftUntilDone")]
        LeftUntilDone,

        /// <summary>
        /// The magnet link for this torrent.
        /// </summary>
        [Display(Description = "magnetLink")]
        MagnetLink,

        /// <summary>
        /// Time when one or more of the torrent's trackers will allow you to manually ask for more peers, or 0 if you can't.
        /// </summary>
        [Display(Description = "manualAnnounceTime")]
        ManualAnnounceTime,

        /// <summary>
        /// Maximum of connected peers.
        /// </summary>
        [Display(Description = "maxConnectedPeers")]
        MaxConnectedPeers,

        /// <summary>
        /// How much of the metadata the torrent has.
        /// For torrents added from a .torrent this will always be 1.
        /// For magnet links, this number will from from 0 to 1 as the metadata is downloaded.
        /// Range is [0..1]
        /// </summary>
        [Display(Description = "metadataPercentComplete")]
        MetadataPercentComplete,

        /// <summary>
        /// Torrent name.
        /// </summary>
        [Display(Description = "name")]
        Name,

        /// <summary>
        /// Maximum number of peers.
        /// </summary>
        [Display(Description = "peer-limit")]
        PeerLimit,

        /// <summary>
        /// Array of peer objects.
        /// </summary>
        [Display(Description = "peers")]
        Peers,

        /// <summary>
        /// Number of peers we are connected to.
        /// </summary>
        [Display(Description = "peersConnected")]
        PeersConnected,

        /// <summary>
        /// Object containing download peers counts for different peer types.
        /// </summary>
        [Display(Description = "peersFrom")]
        PeersFrom,

        /// <summary>
        /// Number of peers we are sending data to.
        /// </summary>
        [Display(Description = "peersGettingFromUs")]
        PeersGettingFromUs,

        /// <summary>
        /// Number of peers sending to us.
        /// </summary>
        [Display(Description = "peersSendingToUs")]
        PeersSendingToUs,

        /// <summary>
        /// How much has been downloaded of the files the user wants.
        /// This differs from percentComplete if the user wants only some of the torrent's files.
        /// Range is [0..1]
        /// </summary>
        [Display(Description = "percentDone")]
        PercentDone,

        /// <summary>
        /// String with base64 encoded bitfield indicating finished pieces.
        /// </summary>
        [Display(Description = "pieces")]
        Pieces,

        /// <summary>
        /// Number of pieces.
        /// </summary>
        [Display(Description = "pieceCount")]
        PieceCount,

        /// <summary>
        /// Number of bytes in a piece.
        /// </summary>
        [Display(Description = "pieceSize")]
        PieceSize,

        /// <summary>
        /// Array of file priorities.
        /// </summary>
        [Display(Description = "priorities")]
        Priorities,

        /// <summary>
        /// This torrent's queue position. All torrents have a queue position, even if it's not queued.
        /// </summary>
        [Display(Description = "queuePosition")]
        QueuePosition,

        /// <summary>
        /// Download rate in bps.
        /// </summary>
        [Display(Description = "rateDownload (B/s)")]
        RateDownload,

        /// <summary>
        /// Upload rate in bps.
        /// </summary>
        [Display(Description = "rateUpload (B/s)")]
        RateUpload,

        /// <summary>
        /// When Activity is TR_STATUS_CHECK or TR_STATUS_CHECK_WAIT, this is the percentage of how much of the files has been verified.
        /// When it gets to 1, the verify process is done.
        /// </summary>
        [Display(Description = "recheckProgress")]
        RecheckProgress,

        /// <summary>
        /// Cumulative seconds the torrent's ever spent downloading
        /// </summary>
        [Display(Description = "secondsDownloading")]
        SecondsDownloading,

        /// <summary>
        /// Cumulative seconds the torrent's ever spent seeding
        /// </summary>
        [Display(Description = "secondsSeeding")]
        SecondsSeeding,

        /// <summary>
        /// Idle limit in minutes.
        /// </summary>
        [Display(Description = "seedIdleLimit")]
        SeedIdleLimit,

        /// <summary>
        /// Use global (0), torrent (1), or unlimited (2) limit.
        /// </summary>
        [Display(Description = "seedIdleMode")]
        SeedIdleMode,

        /// <summary>
        /// Seed ratio limit.
        /// </summary>
        [Display(Description = "seedRatioLimit")]
        SeedRatioLimit,

        /// <summary>
        /// Use global (0), torrent (1), or unlimited (2) limit.
        /// </summary>
        [Display(Description = "seedRatioMode")]
        SeedRatioMode,

        /// <summary>
        /// Byte count of all the piece data we'll have downloaded when we're done, whether or not we have it yet.
        /// This may be less than TotalSize if only some of the torrent's files are wanted.
        /// </summary>
        [Display(Description = "sizeWhenDone")]
        SizeWhenDone,

        /// <summary>
        /// The date when the torrent was last started.
        /// </summary>
        [Display(Description = "startDate")]
        StartDate,

        /// <summary>
        /// Current status, see source.
        /// </summary>
        [Display(Description = "status")]
        Status,

        /// <summary>
        /// Array of tracker objects.
        /// </summary>
        [Display(Description = "trackers")]
        Trackers,

        /// <summary>
        /// Array of object containing tracker statistics.
        /// </summary>
        [Display(Description = "trackerStats")]
        TrackerStats,

        /// <summary>
        /// Total size of the torrent in bytes.
        /// </summary>
        [Display(Description = "totalSize")]
        TotalSize,

        /// <summary>
        /// Path to .torrent file.
        /// </summary>
        [Display(Description = "torrentFile")]
        TorrentFile,

        /// <summary>
        /// Number of bytes uploaded, ever.
        /// </summary>
        [Display(Description = "uploadedEver")]
        UploadedEver,

        /// <summary>
        /// Upload limit in Kbps
        /// </summary>
        [Display(Description = "uploadLimit")]
        UploadLimit,

        /// <summary>
        /// Upload limit enabled.
        /// </summary>
        [Display(Description = "uploadLimited")]
        UploadLimited,

        /// <summary>
        /// Seed ratio.
        /// </summary>
        [Display(Description = "uploadRatio")]
        UploadRatio,

        /// <summary>
        /// Array of booleans indicated wanted files.
        /// </summary>
        [Display(Description = "wanted")]
        Wanted,

        /// <summary>
        /// Array of webseeds objects.
        /// </summary>
        [Display(Description = "webseeds")]
        Webseeds,

        /// <summary>
        /// Number of webseeds seeding to us.
        /// </summary>
        [Display(Description = "webseedsSendingToUs")]
        WebseedsSendingToUs
    }

    public enum TR_STAT_ERRTYPE
    {
        /// <summary>
        /// Everything's fine
        /// </summary>
        TR_STAT_OK = 0,

        /// <summary>
        /// When we anounced to the tracker, we got a warning in the response
        /// </summary>
        TR_STAT_TRACKER_WARNING = 1,

        /// <summary>
        /// When we anounced to the tracker, we got an error in the response
        /// </summary>
        TR_STAT_TRACKER_ERROR = 2,

        /// <summary>
        /// Local trouble, such as disk full or permissions error
        /// </summary>
        TR_STAT_LOCAL_ERROR = 3
    }

    public enum Priority
    {
        TR_PRI_LOW = -1,
        TR_PRI_NORMAL = 0,
        TR_PRI_HIGH = 1
    }

    public enum TR_IDLELIMIT
    {
        /// <summary>
        /// Follow the global settings
        /// </summary>
        TR_IDLELIMIT_GLOBAL = 0,

        /// <summary>
        /// Override the global settings, seeding until a certain idle time
        /// </summary>
        TR_IDLELIMIT_SINGLE = 1,

        /// <summary>
        /// Override the global settings, seeding regardless of activity
        /// </summary>
        TR_IDLELIMIT_UNLIMITED = 2
    }

    public enum TR_RATIOLIMIT
    {
        /// <summary>
        /// Follow the global settings
        /// </summary>
        TR_RATIOLIMIT_GLOBAL = 0,

        /// <summary>
        /// Override the global settings, seeding until a certain ratio
        /// </summary>
        TR_RATIOLIMIT_SINGLE = 1,

        /// <summary>
        /// Override the global settings, seeding regardless of ratio
        /// </summary>
        TR_RATIOLIMIT_UNLIMITED = 2
    }

    public enum TR_TORRENT_ACTIVITY
    {
        /// <summary>
        /// Torrent is stopped.
        /// </summary>
        TR_STATUS_STOPPED = 0,

        /// <summary>
        /// Queued to check files.
        /// </summary>
        TR_STATUS_CHECK_WAIT = 1,
        
        /// <summary>
        /// Checking files.
        /// </summary>
        TR_STATUS_CHECK = 2,
        
        /// <summary>
        /// Queued to download.
        /// </summary>
        TR_STATUS_DOWNLOAD_WAIT = 3,
        
        /// <summary>
        /// Downloading.
        /// </summary>
        TR_STATUS_DOWNLOAD = 4,
        
        /// <summary>
        /// Queued to seed.
        /// </summary>
        TR_STATUS_SEED_WAIT = 5,
        
        /// <summary>
        /// Seeding.
        /// </summary>
        TR_STATUS_SEED = 6
    }

    public enum TR_TRACKER_STATE
    {
        /// <summary>
        /// We won't (announce,scrape) this torrent to this tracker because the torrent is stopped, or because of an error, or whatever.
        /// </summary>
        TR_TRACKER_INACTIVE = 0,

        /// <summary>
        /// We will (announce,scrape) this torrent to this tracker, and are waiting for enough time to pass to satisfy the tracker's interval.
        /// </summary>
        TR_TRACKER_WAITING = 1,

        /// <summary>
        /// It's time to (announce,scrape) this torrent, and we're waiting on a free slot to open up in the announce manager.
        /// </summary>
        TR_TRACKER_QUEUED = 2,

        /// <summary>
        /// We're (announcing,scraping) this torrent right now.
        /// </summary>
        TR_TRACKER_ACTIVE = 3
    }

    internal enum Methods
    {
        [Display(Description = "torrent-get")]
        TorrentGet,

        [Display(Description = "torrent-add")]
        TorrentAdd,

        [Display(Description = "torrent-remove")]
        TorrentRemove,

        [Display(Description = "session-stats")]
        SessionStats,

        [Display(Description = "session-close")]
        SessionClose,
    }
}
using System;
using System.Linq;
using Newtonsoft.Json;
using NTransmissionClient;

namespace NTransmissionClient.Model
{
    /// <example>
    ///Method name: "torrent-get".
    ///
    ///Response arguments:
    ///
    ///(1) A "torrents" array of objects, each of which contains
    ///    the key/value pairs matching the request's "fields" argument.
    ///(2) If the request's "ids" field was "recently-active",
    ///    a "removed" array of torrent-id numbers of recently-removed
    ///    torrents.
    ///
    ///Note: For more information on what these fields mean, see the comments
    ///in libtransmission/transmission.h.  The "source" column here
    ///corresponds to the data structure there.
    ///
    ///key                         | type                        | source
    ///----------------------------+-----------------------------+---------
    ///activityDate                | number                      | tr_stat
    ///addedDate                   | number                      | tr_stat
    ///bandwidthPriority           | number                      | tr_priority_t
    ///comment                     | string                      | tr_info
    ///corruptEver                 | number                      | tr_stat
    ///creator                     | string                      | tr_info
    ///dateCreated                 | number                      | tr_info
    ///desiredAvailable            | number                      | tr_stat
    ///doneDate                    | number                      | tr_stat
    ///downloadDir                 | string                      | tr_torrent
    ///downloadedEver              | number                      | tr_stat
    ///downloadLimit               | number                      | tr_torrent
    ///downloadLimited             | boolean                     | tr_torrent
    ///error                       | number                      | tr_stat
    ///errorString                 | string                      | tr_stat
    ///eta                         | number                      | tr_stat
    ///etaIdle                     | number                      | tr_stat
    ///files                       | array (see below)           | n/a
    ///fileStats                   | array (see below)           | n/a
    ///hashString                  | string                      | tr_info
    ///haveUnchecked               | number                      | tr_stat
    ///haveValid                   | number                      | tr_stat
    ///honorsSessionLimits         | boolean                     | tr_torrent
    ///id                          | number                      | tr_torrent
    ///isFinished                  | boolean                     | tr_stat
    ///isPrivate                   | boolean                     | tr_torrent
    ///isStalled                   | boolean                     | tr_stat
    ///leftUntilDone               | number                      | tr_stat
    ///magnetLink                  | number                      | n/a
    ///manualAnnounceTime          | number                      | tr_stat
    ///maxConnectedPeers           | number                      | tr_torrent
    ///metadataPercentComplete     | double                      | tr_stat
    ///name                        | string                      | tr_info
    ///peer-limit                  | number                      | tr_torrent
    ///peers                       | array (see below)           | n/a
    ///peersConnected              | number                      | tr_stat
    ///peersFrom                   | object (see below)          | n/a
    ///peersGettingFromUs          | number                      | tr_stat
    ///peersSendingToUs            | number                      | tr_stat
    ///percentDone                 | double                      | tr_stat
    ///pieces                      | string (see below)          | tr_torrent
    ///pieceCount                  | number                      | tr_info
    ///pieceSize                   | number                      | tr_info
    ///priorities                  | array (see below)           | n/a
    ///queuePosition               | number                      | tr_stat
    ///rateDownload (B/s)          | number                      | tr_stat
    ///rateUpload (B/s)            | number                      | tr_stat
    ///recheckProgress             | double                      | tr_stat
    ///secondsDownloading          | number                      | tr_stat
    ///secondsSeeding              | number                      | tr_stat
    ///seedIdleLimit               | number                      | tr_torrent
    ///seedIdleMode                | number                      | tr_inactvelimit
    ///seedRatioLimit              | double                      | tr_torrent
    ///seedRatioMode               | number                      | tr_ratiolimit
    ///sizeWhenDone                | number                      | tr_stat
    ///startDate                   | number                      | tr_stat
    ///status                      | number                      | tr_stat
    ///trackers                    | array (see below)           | n/a
    ///trackerStats                | array (see below)           | n/a
    ///totalSize                   | number                      | tr_info
    ///torrentFile                 | string                      | tr_info
    ///uploadedEver                | number                      | tr_stat
    ///uploadLimit                 | number                      | tr_torrent
    ///uploadLimited               | boolean                     | tr_torrent
    ///uploadRatio                 | double                      | tr_stat
    ///wanted                      | array (see below)           | n/a
    ///webseeds                    | array (see below)           | n/a
    ///webseedsSendingToUs         | number                      | tr_stat
    /// </example>
    public class TorrentInfo
    {
        /// <summary>
        /// The last time we uploaded or downloaded piece data on this torrent.
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("activityDate")]
        public DateTime? ActivityDate { get; set; }

        /// <summary>
        /// When the torrent was first added.
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("addedDate")]
        public DateTime? AddedDate { get; set; }

        /// <summary>
        /// Get the torrent's bandwidth priority.
        /// </summary>
        [JsonProperty("bandwidthPriority")]
        public Priority? BandwidthPriority { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Byte count of all the corrupt data you've ever downloaded for this torrent.
        /// If you're on a poisoned torrent, this number can grow very large.
        /// </summary>
        [JsonProperty("corruptEver")]
        public long? CorruptEver { get; set; }

        /// <summary>
        /// Torrent file creator.
        /// </summary>
        [JsonProperty("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Torrent creation date.
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("dateCreated")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Byte count of all the piece data we want and don't have yet, but that a connected peer does have.
        /// </summary>
        [JsonProperty("desiredAvailable")]
        public long? DesiredAvailable { get; set; }

        /// <summary>
        /// When the torrent finished downloading.
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("doneDate")]
        public DateTime? DoneDate { get; set; }

        [JsonProperty("downloadDir")]
        public string DownloadDir { get; set; }

        /// <summary>
        /// Byte count of all the non-corrupt data you've ever downloaded for this torrent.
        /// If you deleted the files and downloaded a second time, this will be 2*totalSize.
        /// </summary>
        [JsonProperty("downloadedEver")]
        public long? DownloadedEver { get; set; }

        [JsonProperty("downloadLimit")]
        public long? DownloadLimit { get; set; }

        [JsonProperty("downloadLimited")]
        public bool? DownloadLimited { get; set; }

        /// <summary>
        /// Defines what kind of text is in errorString.
        /// </summary>
        [JsonProperty("error")]
        public TR_STAT_ERRTYPE? Error { get; set; }

        /// <summary>
        /// A warning or error message regarding the torrent.
        /// </summary>
        [JsonProperty("errorString")]
        public string ErrorString { get; set; }

        [JsonProperty("eta")]
        public long? Eta { get; set; }

        /// <summary>
        /// If seeding, number of seconds left until the idle time limit is reached.
        /// </summary>
        [JsonProperty("etaIdle")]
        public long? EtaIdle { get; set; }

        [JsonProperty("files")]
        public TorrentFile[] Files { get; set; }

        [JsonProperty("fileStats")]
        public FileStats[] FileStats { get; set; }

        /// <summary>
        /// Hashstring unique for the torrent even between sessions.
        /// </summary>
        [JsonProperty("hashString")]
        public string HashString { get; set; }

        /// <summary>
        /// Byte count of all the partial piece data we have for this torrent.
        /// As pieces become complete, this value may decrease as portions of it are moved to `corrupt' or `haveValid'.
        /// </summary>
        [JsonProperty("haveUnchecked")]
        public long? HaveUnchecked { get; set; }

        /// <summary>
        /// Byte count of all the checksum-verified data we have for this torrent.
        /// </summary>
        [JsonProperty("haveValid")]
        public long? HaveValid { get; set; }

        [JsonProperty("honorsSessionLimits")]
        public bool? HonorsSessionLimits { get; set; }

        /// <summary>
        /// The torrent's unique Id.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("isFinished")]
        public bool? IsFinished { get; set; }

        [JsonProperty("isPrivate")]
        public bool? IsPrivate { get; set; }

        [JsonProperty("isStalled")]
        public bool? IsStalled { get; set; }

        /// <summary>
        /// Byte count of how much data is left to be downloaded until we've got all the pieces that we want.
        /// </summary>
        [JsonProperty("leftUntilDone")]
        public long? LeftUntilDone { get; set; }

        [JsonProperty("magnetLink")]
        public string MagnetLink { get; set; }

        /// <summary>
        /// Time when one or more of the torrent's trackers will allow you to manually ask for more peers, or 0 if you can't.
        /// </summary>
        [JsonProperty("manualAnnounceTime")]
        public long? ManualAnnounceTime { get; set; }

        [JsonProperty("maxConnectedPeers")]
        public long? MaxConnectedPeers { get; set; }

        /// <summary>
        /// How much of the metadata the torrent has.
        /// For torrents added from a .torrent this will always be 1.
        /// For magnet links, this number will from from 0 to 1 as the metadata is downloaded.
        /// Range is [0..1]
        /// </summary>
        [JsonProperty("metadataPercentComplete")]
        public float? MetadataPercentComplete { get; set; }

        /// <summary>
        /// The torrent's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("peer-limit")]
        public long? PeerLimit { get; set; }

        [JsonProperty("peers")]
        public Peers[] Peers { get; set; }

        /// <summary>
        /// Number of peers that we're connected to
        /// </summary>
        [JsonProperty("peersConnected")]
        public long? PeersConnected { get; set; }

        [JsonProperty("peersFrom")]
        public PeersFrom PeersFrom { get; set; }

        /// <summary>
        /// Number of peers that we're sending data to
        /// </summary>
        [JsonProperty("peersGettingFromUs")]
        public long? PeersGettingFromUs { get; set; }

        /// <summary>
        /// Number of peers that are sending data to us.
        /// </summary>
        [JsonProperty("peersSendingToUs")]
        public long? PeersSendingToUs { get; set; }

        /// <summary>
        /// How much has been downloaded of the files the user wants.
        /// This differs from percentComplete if the user wants only some of the torrent's files.
        /// Range is [0..1]
        /// </summary>
        [JsonProperty("percentDone")]
        public float? PercentDone { get; set; }

        [JsonProperty("pieces")]
        public string Pieces { get; set; }

        [JsonProperty("pieceCount")]
        public long? PieceCount { get; set; }

        [JsonProperty("pieceSize")]
        public long? PieceSize { get; set; }

        /// <summary>
        /// An array of FileCount numbers.
        /// Each is the Priority mode for the corresponding file.
        /// </summary>
        [JsonProperty("priorities")]
        public Priority[] Priorities { get; set; }

        [JsonProperty("queuePosition")]
        public long? QueuePosition { get; set; }

        [JsonProperty("rateDownload (B/s)")]
        public long? RateDownload { get; set; }

        [JsonProperty("rateUpload (B/s)")]
        public long? RateUpload { get; set; }

        /// <summary>
        /// When Activity is TR_STATUS_CHECK or TR_STATUS_CHECK_WAIT, this is the percentage of how much of the files has been verified.
        /// When it gets to 1, the verify process is done.
        /// </summary>
        [JsonProperty("recheckProgress")]
        public float? RecheckProgress { get; set; }

        [JsonProperty("secondsDownloading")]
        public long? SecondsDownloading { get; set; }

        [JsonProperty("secondsSeeding")]
        public long? SecondsSeeding { get; set; }

        [JsonProperty("seedIdleLimit")]
        public long? SeedIdleLimit { get; set; }

        [JsonProperty("seedIdleMode")]
        public TR_IDLELIMIT? SeedIdleMode { get; set; }

        [JsonProperty("seedRatioLimit")]
        public float? SeedRatioLimit { get; set; }

        [JsonProperty("seedRatioMode")]
        public TR_RATIOLIMIT? SeedRatioMode { get; set; }

        /// <summary>
        /// Byte count of all the piece data we'll have downloaded when we're done, whether or not we have it yet.
        /// This may be less than TotalSize if only some of the torrent's files are wanted.
        /// </summary>
        [JsonProperty("sizeWhenDone")]
        public long? SizeWhenDone { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("status")]
        public TR_TORRENT_ACTIVITY? Status { get; set; }

        [JsonProperty("trackers")]
        public Trackers[] Trackers { get; set; }

        [JsonProperty("trackerStats")]
        public TrackerStats[] TrackerStats { get; set; }

        /// <summary>
        /// Total size of the torrent, in bytes.
        /// </summary>
        [JsonProperty("totalSize")]
        public long? TotalSize { get; set; }

        [JsonProperty("torrentFile")]
        public string TorrentFile { get; set; }

        /// <summary>
        /// Byte count of all data you've ever uploaded for this torrent.
        /// </summary>
        [JsonProperty("uploadedEver")]
        public long? UploadedEver { get; set; }

        [JsonProperty("uploadLimit")]
        public long? UploadLimit { get; set; }

        [JsonProperty("uploadLimited")]
        public bool? UploadLimited { get; set; }

        [JsonProperty("uploadRatio")]
        public float? UploadRatio { get; set; }

        /// <summary>
        /// An array of FileCount 'booleans' true if the corresponding file is to be downloaded. 
        /// </summary>
        [JsonProperty("wanted")]
        public bool[] Wanted { get; set; }

        [JsonProperty("webseeds")]
        public string[] Webseeds { get; set; }

        [JsonProperty("webseedsSendingToUs")]
        public long? WebseedsSendingToUs { get; set; }
    }
}
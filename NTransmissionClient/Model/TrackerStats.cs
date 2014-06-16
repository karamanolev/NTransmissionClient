using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <example>
    ///-------------------+--------------------------------------+
    ///trackerStats       | array of objects, each containing:   |
    ///                   +-------------------------+------------+
    ///                   | announce                | string     | tr_tracker_stat
    ///                   | announceState           | number     | tr_tracker_stat
    ///                   | downloadCount           | number     | tr_tracker_stat
    ///                   | hasAnnounced            | boolean    | tr_tracker_stat
    ///                   | hasScraped              | boolean    | tr_tracker_stat
    ///                   | host                    | string     | tr_tracker_stat
    ///                   | id                      | number     | tr_tracker_stat
    ///                   | isBackup                | boolean    | tr_tracker_stat
    ///                   | lastAnnouncePeerCount   | number     | tr_tracker_stat
    ///                   | lastAnnounceResult      | string     | tr_tracker_stat
    ///                   | lastAnnounceStartTime   | number     | tr_tracker_stat
    ///                   | lastAnnounceSucceeded   | boolean    | tr_tracker_stat
    ///                   | lastAnnounceTime        | number     | tr_tracker_stat
    ///                   | lastAnnounceTimedOut    | boolean    | tr_tracker_stat
    ///                   | lastScrapeResult        | string     | tr_tracker_stat
    ///                   | lastScrapeStartTime     | number     | tr_tracker_stat
    ///                   | lastScrapeSucceeded     | boolean    | tr_tracker_stat
    ///                   | lastScrapeTime          | number     | tr_tracker_stat
    ///                   | lastScrapeTimedOut      | boolean    | tr_tracker_stat
    ///                   | leecherCount            | number     | tr_tracker_stat
    ///                   | nextAnnounceTime        | number     | tr_tracker_stat
    ///                   | nextScrapeTime          | number     | tr_tracker_stat
    ///                   | scrape                  | string     | tr_tracker_stat
    ///                   | scrapeState             | number     | tr_tracker_stat
    ///                   | seederCount             | number     | tr_tracker_stat
    ///                   | tier                    | number     | tr_tracker_stat
    ///-------------------+-------------------------+------------+
    /// </example>
    public class TrackerStats
    {
        [JsonProperty("announce")]
        public string Announce { get; set; }

        [JsonProperty("announceState")]
        public long? AnnounceState { get; set; }

        [JsonProperty("downloadCount")]
        public long? DownloadCount { get; set; }

        [JsonProperty("hasAnnounced")]
        public bool? HasAnnounced { get; set; }

        [JsonProperty("hasScraped")]
        public bool? HasScraped { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("isBackup")]
        public bool? IsBackup { get; set; }

        [JsonProperty("lastAnnouncePeerCount")]
        public long? LastAnnouncePeerCount { get; set; }

        [JsonProperty("lastAnnounceResult")]
        public string LastAnnounceResult { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("lastAnnounceStartTime")]
        public DateTime? LastAnnounceStartTime { get; set; }

        [JsonProperty("lastAnnounceSucceeded")]
        public bool? LastAnnounceSucceeded { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("lastAnnounceTime")]
        public DateTime? LastAnnounceTime { get; set; }

        [JsonProperty("lastAnnounceTimedOut")]
        public bool? LastAnnounceTimedOut { get; set; }

        [JsonProperty("lastScrapeResult")]
        public string LastScrapeResult { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("lastScrapeStartTime")]
        public DateTime? LastScrapeStartTime { get; set; }

        [JsonProperty("lastScrapeSucceeded")]
        public bool? LastScrapeSucceeded { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("lastScrapeTime")]
        public DateTime? LastScrapeTime { get; set; }

        [JsonProperty("lastScrapeTimedOut")]
        public bool? LastScrapeTimedOut { get; set; }

        [JsonProperty("leecherCount")]
        public long? LeecherCount { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("nextAnnounceTime")]
        public DateTime? NextAnnounceTime { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("nextScrapeTime")]
        public DateTime? NextScrapeTime { get; set; }

        [JsonProperty("scrape")]
        public string Scrape { get; set; }

        [JsonProperty("scrapeState")]
        public TR_TRACKER_STATE? ScrapeState { get; set; }

        [JsonProperty("seederCount")]
        public long? SeederCount { get; set; }

        [JsonProperty("tier")]
        public long? Tier { get; set; }
    }
}
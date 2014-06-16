using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{

    /// <example>
    ///-------------------+--------------------------------------+
    ///trackers           | array of objects, each containing:   |
    ///                   +-------------------------+------------+
    ///                   | announce                | string     | tr_tracker_info
    ///                   | id                      | number     | tr_tracker_info
    ///                   | scrape                  | string     | tr_tracker_info
    ///                   | tier                    | number     | tr_tracker_info
    ///-------------------+--------------------------------------+
    /// </example>
    public class Trackers
    {
        [JsonProperty("announce")]
        public string Announce { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("scrape")]
        public string Scrape { get; set; }

        [JsonProperty("tier")]
        public long? Tier { get; set; }
    }
}
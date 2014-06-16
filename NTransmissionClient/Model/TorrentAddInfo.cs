using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <example>
    ///Response arguments: On success, a "torrent-added" object in the
    ///                    form of one of 3.3's tr_info objects with the
    ///                    fields for id, name, and hashString.
    ///
    ///                    On failure due to a duplicate torrent existing,
    ///                    a "torrent-duplicate" object in the same form.
    /// </example>
    public class TorrentAddInfo
    {
        [JsonProperty("hashString")]
        public string HashString { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
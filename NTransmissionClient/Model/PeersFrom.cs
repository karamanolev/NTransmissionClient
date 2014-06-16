using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <example>
    ///-------------------+--------------------------------------+
    ///peersFrom          | an object containing:                |
    ///                   +-------------------------+------------+
    ///                   | fromCache               | number     | tr_stat
    ///                   | fromDht                 | number     | tr_stat
    ///                   | fromIncoming            | number     | tr_stat
    ///                   | fromLpd                 | number     | tr_stat
    ///                   | fromLtep                | number     | tr_stat
    ///                   | fromPex                 | number     | tr_stat
    ///                   | fromTracker             | number     | tr_stat
    ///-------------------+--------------------------------------+
    /// </example>
    public class PeersFrom
    {
        [JsonProperty("fromCache")]
        public long? FromCache { get; set; }

        [JsonProperty("fromDht")]
        public long? FromDht { get; set; }

        [JsonProperty("fromIncoming")]
        public long? FromIncoming { get; set; }

        [JsonProperty("fromLpd")]
        public long? FromLpd { get; set; }

        [JsonProperty("fromLtep")]
        public long? FromLtep { get; set; }

        [JsonProperty("fromPex")]
        public long? FromPex { get; set; }

        [JsonProperty("fromTracker")]
        public long? FromTracker { get; set; }
    }
}
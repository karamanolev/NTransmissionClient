using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <example>
    ///-------------------+--------------------------------------+
    ///peers              | array of objects, each containing:   |
    ///                   +-------------------------+------------+
    ///                   | address                 | string     | tr_peer_stat
    ///                   | clientName              | string     | tr_peer_stat
    ///                   | clientIsChoked          | boolean    | tr_peer_stat
    ///                   | clientIsInterested      | boolean    | tr_peer_stat
    ///                   | flagStr                 | string     | tr_peer_stat
    ///                   | isDownloadingFrom       | boolean    | tr_peer_stat
    ///                   | isEncrypted             | boolean    | tr_peer_stat
    ///                   | isIncoming              | boolean    | tr_peer_stat
    ///                   | isUploadingTo           | boolean    | tr_peer_stat
    ///                   | isUTP                   | boolean    | tr_peer_stat
    ///                   | peerIsChoked            | boolean    | tr_peer_stat
    ///                   | peerIsInterested        | boolean    | tr_peer_stat
    ///                   | port                    | number     | tr_peer_stat
    ///                   | progress                | double     | tr_peer_stat
    ///                   | rateToClient (B/s)      | number     | tr_peer_stat
    ///                   | rateToPeer (B/s)        | number     | tr_peer_stat
    ///-------------------+--------------------------------------+
    /// </example>
    public class Peers
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("clientIsChoked")]
        public bool? ClientIsChoked { get; set; }

        [JsonProperty("clientIsInterested")]
        public bool? ClientIsInterested { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("flagStr")]
        public string FlagStr { get; set; }

        [JsonProperty("isDownloadingFrom")]
        public bool? IsDownloadingFrom { get; set; }

        [JsonProperty("isEncrypted")]
        public bool? IsEncrypted { get; set; }

        [JsonProperty("isIncoming")]
        public bool? IsIncoming { get; set; }

        [JsonProperty("isUTP")]
        public bool? IsUTP { get; set; }

        [JsonProperty("isUploadingTo")]
        public bool? IsUploadingTo { get; set; }

        [JsonProperty("peerIsChoked")]
        public bool? PeerIsChoked { get; set; }

        [JsonProperty("peerIsInterested")]
        public bool? PeerIsInterested { get; set; }

        [JsonProperty("port")]
        public long? Port { get; set; }

        [JsonProperty("progress")]
        public double? Progress { get; set; }

        [JsonProperty("rateToClient")]
        public long? RateToClient { get; set; }

        [JsonProperty("rateToPeer")]
        public long? RateToPeer { get; set; }
    }
}
using System;
using System.Linq;
using Newtonsoft.Json;

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
    /// </example>
    public class TorrentGetResponse
    {
        [JsonProperty("torrents")]
        public TorrentInfo[] Torrents { get; set; }

        [JsonProperty("removed")]
        public long[] Removed { get; set; }
    }
}
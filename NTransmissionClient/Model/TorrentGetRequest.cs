using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <example>
    ///Method name: "torrent-get".
    ///
    ///Request arguments:
    ///
    ///(1) An optional "ids" array as described in 3.1.
    ///(2) A required "fields" array of keys. (see list below)
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
    /// </example>
    public class TorrentGetRequest
    {
        [JsonProperty("ids")]
        public object Ids { get; set; }

        [JsonProperty("fields")]
        public string[] Fields { get; set; }
    }
}
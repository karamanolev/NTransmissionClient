using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <example>
    ///Method name: "torrent-remove"
    ///
    ///Request arguments:
    ///
    ///string                     | value type & description
    ///---------------------------+-------------------------------------------------
    ///"ids"                      | array      torrent list, as described in 3.1
    ///"delete-local-data"        | boolean    delete local data. (default: false)
    ///
    ///"ids", which specifies which torrents to use.
    ///All torrents are used if the "ids" argument is omitted.
    ///"ids" should be one of the following:
    ///(1) an integer referring to a torrent id
    ///(2) a list of torrent id numbers, sha1 hash strings, or both
    ///(3) a string, "recently-active", for recently-active torrents
    /// 
    ///Response arguments: none
    /// </example>
    public class TorrentDeleteRequest
    {
        [JsonProperty("ids")]
        public object Ids { get; set; }

        [JsonProperty("delete-local-data")]
        public bool DeleteLocalData { get; set; }
    }
}
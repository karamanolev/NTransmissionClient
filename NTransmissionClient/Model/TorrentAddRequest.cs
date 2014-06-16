using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <example>
    ///Method name: "torrent-add"
    ///
    ///Request arguments:
    ///
    ///key                  | value type & description
    ///---------------------+-------------------------------------------------
    ///"cookies"            | string      pointer to a string of one or more cookies.
    ///"download-dir"       | string      path to download the torrent to
    ///"filename"           | string      filename or URL of the .torrent file
    ///"metainfo"           | string      base64-encoded .torrent content
    ///"paused"             | boolean     if true, don't start the torrent
    ///"peer-limit"         | number      maximum number of peers
    ///"bandwidthPriority"  | number      torrent's bandwidth tr_priority_t
    ///"files-wanted"       | array       indices of file(s) to download
    ///"files-unwanted"     | array       indices of file(s) to not download
    ///"priority-high"      | array       indices of high-priority file(s)
    ///"priority-low"       | array       indices of low-priority file(s)
    ///"priority-normal"    | array       indices of normal-priority file(s)
    ///
    ///Either "filename" OR "metainfo" MUST be included.
    ///All other arguments are optional.
    ///
    ///The format of the "cookies" should be NAME=CONTENTS, where NAME is the
    ///cookie name and CONTENTS is what the cookie should contain.
    ///Set multiple cookies like this: "name1=content1; name2=content2;" etc.
    ///<http://curl.haxx.se/libcurl/c/curl_easy_setopt.html#CURLOPTCOOKIE>
    ///
    ///Response arguments: On success, a "torrent-added" object in the
    ///                    form of one of 3.3's tr_info objects with the
    ///                    fields for id, name, and hashString.
    ///
    ///                    On failure due to a duplicate torrent existing,
    ///                    a "torrent-duplicate" object in the same form.
    /// </example>
    public class TorrentAddRequest
    {
        [JsonProperty("cookies")]
        public string Cookies { get; set; }

        [JsonProperty("download-dir")]
        public string DownloadDir { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; private set; }

        [JsonProperty("metainfo")]
        public string MetaInfo { get; private set; }

        [JsonProperty("paused")]
        public bool? Paused { get; set; }

        [JsonProperty("peer-limit")]
        public long? PeerLimit { get; set; }

        [JsonProperty("bandwidthPriority")]
        public long? BandwidthPriority { get; set; }

        [JsonProperty("files-wanted")]
        public long[] FilesWanted { get; set; }

        [JsonProperty("files-unwanted")]
        public long[] FilesUnwanted { get; set; }

        [JsonProperty("priority-high")]
        public long[] PriorityHigh { get; set; }

        [JsonProperty("priority-normal")]
        public long[] PriorityNormal { get; set; }

        [JsonProperty("priority-low")]
        public long[] PriorityLow { get; set; }

        public TorrentAddRequest(byte[] bytes)
        {
            this.MetaInfo = Convert.ToBase64String(bytes);
        }

        public TorrentAddRequest(string filename)
        {
            this.Filename = filename;
        }
    }
}
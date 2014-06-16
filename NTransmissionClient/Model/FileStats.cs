using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <summary>
    /// A file's non-constant properties.
    /// </summary>
    /// <example>
    ///---------------+--------------------------------------+
    ///fileStats      | a file's non-constant properties.    |
    ///               | array of tr_info.filecount objects,  |
    ///               | each containing:                     |
    ///               +-------------------------+------------+
    ///               | bytesCompleted          | number     | tr_torrent
    ///               | wanted                  | boolean    | tr_info
    ///               | priority                | number     | tr_info
    ///---------------+--------------------------------------+
    /// </example>
    public class FileStats
    {
        [JsonProperty("bytesCompleted")]
        public long? BytesCompleted { get; set; }

        [JsonProperty("priority")]
        public long? Priority { get; set; }

        [JsonProperty("wanted")]
        public bool? Wanted { get; set; }
    }
}
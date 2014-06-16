using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <example>
    ///-------------------+--------+-----------------------------+
    ///file               | objecs containing:                   |
    ///                   +-------------------------+------------+
    ///                   | bytesCompleted          | number     | tr_torrent
    ///                   | length                  | number     | tr_info
    ///                   | name                    | string     | tr_info
    ///-------------------+--------------------------------------+
    /// </example>
    public class TorrentFile
    {
        [JsonProperty("bytesCompleted")]
        public long? BytesCompleted { get; set; }

        [JsonProperty("length")]
        public long? Length { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonIgnore]
        public bool IsComplete
        {
            get { return Length == BytesCompleted; }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
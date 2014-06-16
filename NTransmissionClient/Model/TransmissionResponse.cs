using System;
using System.Linq;
using Newtonsoft.Json;

namespace NTransmissionClient.Model
{
    /// <remarks>
    ///Reponses support three keys:
    ///
    ///(1) A required "result" string whose value MUST be "success" on success,
    ///    or an error string on failure.
    ///(2) An optional "arguments" object of key/value pairs
    ///(3) An optional "tag" number as described in 2.1.
    /// </remarks>
    public class TransmissionResponse<T> : TransmissionResponse
    {
        [JsonProperty("arguments")]
        public T Arguments { get; set; }
    }

    public class TransmissionResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}
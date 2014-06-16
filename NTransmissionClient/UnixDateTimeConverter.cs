using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTransmissionClient
{
    internal class UnixDateTimeConverter : DateTimeConverterBase
    {
        private static DateTime epoc = new DateTime(1970, 1, 1);

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (!(value is DateTime))
                throw new Exception("Expected date object value.");

            if ((DateTime)value == DateTime.MinValue)
                writer.WriteValue(0);

            var delta = (DateTime)value - epoc;

            if (delta.TotalSeconds < 0)
                throw new ArgumentOutOfRangeException("Invalid date object value.");

            writer.WriteValue((long)delta.TotalSeconds);
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name = "reader">The <see cref = "JsonReader" /> to read from.</param>
        /// <param name = "objectType">Type of the object.</param>
        /// <param name = "existingValue">The existing value of object being read.</param>
        /// <param name = "serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Integer)
                throw new Exception("Wrong token type - must be Integer.");

            return (long)reader.Value != 0 ? epoc.AddSeconds((long)reader.Value) : (DateTime?)null;
        }
    }
}

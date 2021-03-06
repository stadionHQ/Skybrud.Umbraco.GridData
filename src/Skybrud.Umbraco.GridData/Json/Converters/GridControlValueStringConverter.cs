using System;
using Newtonsoft.Json;
using Skybrud.Umbraco.GridData.Values;

namespace Skybrud.Umbraco.GridData.Json.Converters {

    /// <summary>
    /// Converter for text based grid control values.
    /// </summary>
    public class GridControlValueStringConverter : JsonConverter {

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            GridControlTextValue text = value as GridControlTextValue;
            if (text != null) {
                writer.WriteValue(text.Value);
                return;
            }
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            throw new NotImplementedException("Unnecessary because CanRead is false. The type will skip the converter.");
        }

        public override bool CanRead {
            get { return false; }
        }

        public override bool CanConvert(Type type) {
            return false;
        }
    
    }

}
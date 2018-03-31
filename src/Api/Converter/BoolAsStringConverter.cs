namespace Cleeng.Api.Converter
{
    using System;
    using Newtonsoft.Json;

    internal class BoolAsStringConverter : JsonConverter
    {
        public override bool CanRead => true;
        public override bool CanWrite => true;

        public override bool CanConvert(Type objectType) => objectType.Equals(typeof(bool)) || objectType.Equals(typeof(bool?));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.ReadAsString() == "true";
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            bool? boolValue = (bool?)value;
            if (!boolValue.HasValue)
            {
                return;
            }
            writer.WriteValue(boolValue.Value ? "true" : "false");
        }
    }
}

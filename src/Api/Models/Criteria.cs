namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Converter;

    public class Criteria
    {
        // The Cleeng API does not handle this property as a real boolean but uses its string representation
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(BoolAsStringConverter))]
        public bool? Active { get; set; }

        [JsonProperty("associateEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateEmail { get; set; }
    }
}
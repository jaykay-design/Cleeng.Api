namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class LocaleDataResult : IResultMessage
    {
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }

    }
}
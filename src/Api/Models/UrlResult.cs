namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class UrlResult : IResultMessage
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }
}
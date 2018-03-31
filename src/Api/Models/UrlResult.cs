namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class UrlResult : IResultMessage
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
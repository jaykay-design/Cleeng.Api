namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class VodOfferResult : IResultMessage
    {
        [JsonProperty("vod", NullValueHandling = NullValueHandling.Ignore)]
        public Vod Vod { get; set; }
    }
}

namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class VodOfferResult : IResultMessage
    {
        [JsonProperty("vod")]
        public Vod Vod { get; set; }
    }
}

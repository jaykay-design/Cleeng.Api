namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class FlowDescription
    {
        [JsonProperty("offerId")]
        public string OfferId { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }

        public FlowDescription()
        {

        }

        public FlowDescription(string offerId, string url)
        {
            this.OfferId = offerId;
            this.Url = url;
        }
    }
}

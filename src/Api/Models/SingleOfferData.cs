namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class SingleOfferData : BaseOfferDataForRequests
    {
        [JsonProperty("videoId")]
        public string VideoId { get; set; }
        [JsonProperty("contentExternalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentExternalId { get; set; }
        [JsonProperty("contentExternalData", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentExternalData { get; set; }
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }
    }
}
namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class SingleOfferData : BaseOfferDataForRequests
    {
        [JsonProperty("videoId")]
        public string VideoId { get; set; }
        [JsonProperty("contentExternalId")]
        public string ContentExternalId { get; set; }
        [JsonProperty("contentExternalData")]
        public string ContentExternalData { get; set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
}
namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class SingleOfferResult : BaseOfferData, IResultMessage
    {
        [JsonProperty("videoId")]
        public string VideoId { get; set; }
        [JsonProperty("contentExternalId")]
        public string ContentExternalId { get; set; }
        [JsonProperty("contentExternalData")]
        public string ContentExternalData { get; set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
        [JsonProperty("contentAgeRestriction")]
        public string ContentAgeRestriction { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("publisherEmail")]
        public string PublisherEmail { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("applicableTaxRate")]
        public double ApplicableTaxRate { get; set; }
        [JsonProperty("socialCommissionRate")]
        public int SocialCommissionRate { get; set; }
        [JsonProperty("averageRating")]
        public int AverageRating { get; set; }
        [JsonProperty("contentType")]
        public string ContentType { get; set; }
    }
}
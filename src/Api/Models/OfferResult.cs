namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;

    public class OfferResult : BaseOfferData
    {
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
        [JsonProperty("expiresAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; }
        [JsonProperty("period")]
        public string Period { get; set; }
        [JsonProperty("freePeriods")]
        public int FreePeriods { get; set; }
        [JsonProperty("freeDays")]
        public int FreeDays { get; set; }
        [JsonProperty("accessToTags")]
        public List<string> AccessToTags { get; set; }
    }
}
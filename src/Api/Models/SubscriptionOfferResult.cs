namespace Cleeng.Api.Models
{
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class SubscriptionOfferResult : IResultMessage
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("publisherEmail")]
        public string PublisherEmail { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("createdAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updatedAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("accessToTags")]
        public List<string> AccessToTags;
    }
}
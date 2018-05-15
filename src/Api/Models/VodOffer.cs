namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;

    public class VodOffer
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public double Price { get; set; }
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CreatedAt { get; set; }
        [JsonProperty("applicableTaxRate", NullValueHandling = NullValueHandling.Ignore)]
        public double ApplicableTaxRate { get; set; }
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
        [JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)]
        public string Background { get; set; }
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }
        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? UpdatedAt { get; set; }
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
        [JsonProperty("shortUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortUrl { get; set; }
        [JsonProperty("publisherEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string PublisherEmail { get; set; }

        public VodOffer()
        {

        }
    }
}

namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;

    public class VodOffer
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("createdAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("applicableTaxRate")]
        public double ApplicableTaxRate { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("background")]
        public string Background { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("updatedAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("shortUrl")]
        public string ShortUrl { get; set; }
        [JsonProperty("publisherEmail")]
        public string PublisherEmail { get; set; }

        public VodOffer()
        {

        }
    }
}

namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;

    public class EventOfferResult : BaseOfferData, IResultMessage
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("publisherEmail")]
        public string PublisherEmail { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("applicableTaxRate")]
        public int ApplicableTaxRate { get; set; }
        [JsonProperty("socialCommissionRate")]
        public int SocialCommissionRate { get; set; }
        [JsonProperty("averageRating")]
        public int AverageRating { get; set; }
        [JsonProperty("contentType")]
        public string ContentType { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("playerCode")]
        public string PlayerCode { get; set; }
        [JsonProperty("playerCodeHead")]
        public string PlayerCodeHead { get; set; }
        [JsonProperty("startTime")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime StartTime { get; set; }
        [JsonProperty("endTime")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime EndTime { get; set; }
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
        [JsonProperty("videoId")]
        public string VideoId { get; set; }
        [JsonProperty("viewerEstimate")]
        public string ViewerEstimate { get; set; }
        [JsonProperty("teaser")]
        public string Teaser { get; set; }
        [JsonProperty("applyServiceFeeOnCustomer")]
        public bool ApplyServiceFeeOnCustomer { get; set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
        [JsonProperty("backgroundImageUrl")]
        public BackgroundImages BackgroundImageUrl { get; set; }

    }
}
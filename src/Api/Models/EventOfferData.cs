namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;

    public class EventOfferData : BaseOfferDataForRequests, IRequestMessage
    {
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
    }
}

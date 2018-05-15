namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;

    public class EventOfferData : BaseOfferDataForRequests, IRequestMessage
    {
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }
        [JsonProperty("playerCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayerCode { get; set; }
        [JsonProperty("playerCodeHead", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayerCodeHead { get; set; }
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartTime { get; set; }
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EndTime { get; set; }
        [JsonProperty("timeZone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }
        [JsonProperty("videoId", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoId { get; set; }
        [JsonProperty("viewerEstimate", NullValueHandling = NullValueHandling.Ignore)]
        public string ViewerEstimate { get; set; }
        [JsonProperty("teaser", NullValueHandling = NullValueHandling.Ignore)]
        public string Teaser { get; set; }
        [JsonProperty("applyServiceFeeOnCustomer", NullValueHandling = NullValueHandling.Ignore)]
        public bool ApplyServiceFeeOnCustomer { get; set; }
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }
    }
}

namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;

    public class PassOfferData : BaseOfferDataForRequests
    {
        [JsonProperty("accessToTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessToTags { get; set; }
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        [JsonProperty("expiresAt", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        public PassOfferData()
        {

        }
    }
}
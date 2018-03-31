namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;

    public class PassOfferData : BaseOfferDataForRequests
    {
        [JsonProperty("accessToTags")]
        public List<string> AccessToTags { get; set; }
        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("expiresAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; }

        public PassOfferData()
        {

        }
    }
}
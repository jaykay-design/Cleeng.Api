namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class OfferData : BaseOfferDataForRequests
    {
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }
        [JsonProperty("freePeriods", NullValueHandling = NullValueHandling.Ignore)]
        public int FreePeriods { get; set; }
        [JsonProperty("freeDays", NullValueHandling = NullValueHandling.Ignore)]
        public int FreeDays { get; set; }
        [JsonProperty("accessToTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessToTags;
    }
}
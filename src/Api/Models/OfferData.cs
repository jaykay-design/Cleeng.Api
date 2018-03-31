namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class OfferData : BaseOfferDataForRequests
    {
        [JsonProperty("period")]
        public string Period { get; set; }
        [JsonProperty("freePeriods")]
        public int FreePeriods { get; set; }
        [JsonProperty("freeDays")]
        public int FreeDays { get; set; }
        [JsonProperty("accessToTags")]
        public List<string> AccessToTags;
    }
}
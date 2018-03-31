namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class ListOfferIdsByVideoIdResult
    {
        [JsonProperty("offerIds")]
        public List<string> OfferIds { get; set; }
    }
}

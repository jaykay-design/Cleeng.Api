namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class VodOfferData : BaseOfferDataForRequests, IResultMessage
    {
        [JsonProperty("videoId", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoId { get; set; }
        [JsonProperty("playerCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayerCode { get; set; }
        [JsonProperty("playerCodeHead", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayerCodeHead { get; set; }
        [JsonProperty("rentalPeriod", NullValueHandling = NullValueHandling.Ignore)]
        public string RentalPeriod { get; set; }
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public string Runtime { get; set; }
        [JsonProperty("videoQuality", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoQuality { get; set; }
        [JsonProperty("eventAssociation", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EventAssociation { get; set; }
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }
        [JsonProperty("backgroundImageUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string BackgroundImageUrl { get; set; }
    }
}
namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class VodOfferData : BaseOfferDataForRequests, IResultMessage
    {
        [JsonProperty("videoId")]
        public string VideoId { get; set; }
        [JsonProperty("playerCode")]
        public string PlayerCode { get; set; }
        [JsonProperty("playerCodeHead")]
        public string PlayerCodeHead { get; set; }
        [JsonProperty("rentalPeriod")]
        public string RentalPeriod { get; set; }
        [JsonProperty("runtime")]
        public string Runtime { get; set; }
        [JsonProperty("videoQuality")]
        public string VideoQuality { get; set; }
        [JsonProperty("eventAssociation")]
        public List<string> EventAssociation { get; set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
        [JsonProperty("backgroundImageUrl")]
        public string BackgroundImageUrl { get; set; }
    }
}
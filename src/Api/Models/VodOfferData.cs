namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class VodOfferData : BaseOfferDataForRequests, IResultMessage
    {
        public VodOfferData(Vod vod)
        {
            this.Description = vod.Description;
            this.EventAssociation = vod.EventAssociation;
            this.BackgroundImageUrl = vod.BackgroundImageUrl.Large;
            this.CreatedAt = vod.CreatedAt;
            this.GeoRestrictionCountries = vod.GeoRestrictionCountries;
            this.GeoRestrictionEnabled = vod.GeoRestrictionEnabled;
            this.GeoRestrictionType = vod.GeoRestrictionType;
            this.MembershipOnly = vod.MembershipOnly;
            this.PlayerCode = vod.PlayerCode;
            this.PlayerCodeHead = vod.PlayerCodeHead;
            this.Price = vod.Price;
            this.RentalPeriod = vod.RentalPeriod;
            this.Runtime = vod.Runtime;
            this.Tags = vod.Tags;
            this.Title = vod.Title;
            this.UpdatedAt = vod.UpdatedAt;
            this.Url = vod.Url;
            this.VideoId = vod.VideoId;
            this.VideoQuality = vod.VideoQuality;
        }

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
namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Vod : BaseOfferData
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("publisherEmail")]
        public string PublisherEmail { get; set; }

        [JsonProperty("videoId")]
        public string VideoId { get; set; }
        [JsonProperty("rentalPeriod")]
        public string RentalPeriod { get; set; }

        [JsonProperty("playerCode")]
        public string PlayerCode { get; set; }
        [JsonProperty("playerCodeHead")]
        public string PlayerCodeHead { get; set; }
        [JsonProperty("streamingPlatform")]
        public string StreamingPlatform { get; set; }
        [JsonProperty("runtime")]
        public string Runtime { get; set; }
        [JsonProperty("videoQuality")]
        public string VideoQuality { get; set; }

        [JsonProperty("backgroundImageUrl")]
        public BackgroundImages BackgroundImageUrl { get; set; }

        [JsonProperty("eventAssociation")]
        public List<string> EventAssociation { get; set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
}

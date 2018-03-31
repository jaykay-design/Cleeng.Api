namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class RentalOfferData : IRequestMessage
    {
        [JsonProperty("period")]
        public int Period { get; set; }
        [JsonProperty("videoId")]
        public string VideoId { get; set; }
        [JsonProperty("contentExternalId")]
        public string ContentExternalId { get; set; }
        [JsonProperty("contentExternalData")]
        public string ContentExternalData { get; set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
        [JsonProperty("associateEmail")]
        public string AssociateEmail { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }

        public RentalOfferData(double price,
                               string title,
                               int period,
                               string url,
                               string description,
                               string associateEmail,
                               string videoId,
                               string contentExternalId,
                               string contentExternalData,
                               List<string> tags)
        {
            this.Price = price;
            this.Title = title;
            this.Url = url;
            this.Description = description;
            this.Period = period;
            this.VideoId = videoId;
            this.ContentExternalId = contentExternalId;
            this.ContentExternalData = contentExternalData;
            this.AssociateEmail = associateEmail;
            this.Tags = tags;
        }

        public RentalOfferData()
        {

        }
    }
}
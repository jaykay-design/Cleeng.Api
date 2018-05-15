namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class RentalOfferData : IRequestMessage
    {
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int Period { get; set; }
        [JsonProperty("videoId", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoId { get; set; }
        [JsonProperty("contentExternalId", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentExternalId { get; set; }
        [JsonProperty("contentExternalData", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentExternalData { get; set; }
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }
        [JsonProperty("associateEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateEmail { get; set; }
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public double Price { get; set; }
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
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
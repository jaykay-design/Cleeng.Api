namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class OfferParams<T>
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }
        [JsonProperty("offerData")]
        public T OfferData { get; set; }

        public OfferParams(string publisherToken, T offerData)
        {
            this.PublisherToken = publisherToken;
            this.OfferData = offerData;
        }
    }
}
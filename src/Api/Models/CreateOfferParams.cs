namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class CreateOfferParams<T>: IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }

        [JsonProperty("offerData")]
        public T OfferData { get; set; }

        public CreateOfferParams()
        {

        }

        public CreateOfferParams(string publisherToken, T offerData)
        {
            this.PublisherToken = publisherToken;
            this.OfferData = offerData;
        }
    }
}

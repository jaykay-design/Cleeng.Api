namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GetVodOfferParams : IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }

        [JsonProperty("offerIdString")]
        public string OfferIdString { get; set; }

        public GetVodOfferParams()
        {

        }

        public GetVodOfferParams(string publisherToken, string offerIdString)
        {
            this.PublisherToken = publisherToken;
            this.OfferIdString = offerIdString;
        }
    }
}
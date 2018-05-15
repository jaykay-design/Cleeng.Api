namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class UpdateVodOfferParams : CreateOfferParams<VodOfferData>
    {
        [JsonProperty("offerIdString")]
        public string OfferIdString { get; set; }

        public UpdateVodOfferParams()
        {

        }

        public UpdateVodOfferParams(string publisherToken, VodOfferData offerData, string offerId)
        {
            this.PublisherToken = publisherToken;
            this.OfferData = offerData;
            this.OfferIdString = offerId;
        }
    }
}
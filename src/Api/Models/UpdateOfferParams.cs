namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class UpdateOfferParams<T> : OfferParams<T>, IRequestMessage
    {
        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        public UpdateOfferParams(string publisherToken, T offerData, string offerId) 
            : base(publisherToken, offerData)
        {
            this.OfferId = offerId;
        }
    }
}

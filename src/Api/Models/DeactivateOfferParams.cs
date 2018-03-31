namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class DeactivateOfferParams : GetOfferParams
    {
        /// <summary>
        /// Your publisher token
        /// </summary>
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }


        public DeactivateOfferParams()
        {

        }

        public DeactivateOfferParams(string publisherToken, string offerId, string videoId = null)
            : base(offerId, videoId)
        {
            this.PublisherToken = publisherToken;
        }
    }
}
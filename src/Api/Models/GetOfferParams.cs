namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GetOfferParams : IRequestMessage
    {
        /// <summary>
        /// Id of an offer you want to get info about.
        /// </summary>
        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        /// <summary>
        ///  Unique identifier of your video asset. 
        /// </summary>
        [JsonProperty("videoId")]
        public string VideoId { get; set; }

        public GetOfferParams()
        {

        }

        public GetOfferParams(string offerId, string videoId = null)
        {
            this.OfferId = offerId;
            this.VideoId = videoId;
        }
    }
}
namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class UpdateCustomerRentalParams :  IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }
        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }
        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        [JsonProperty("rentalData")]
        public RentalData RentalData { get; set; }

        public UpdateCustomerRentalParams(string publisherToken,
                                                string customerEmail,
                                                string offerId,
                                                RentalData rentalData)
        {
            this.PublisherToken = publisherToken;
            this.CustomerEmail = customerEmail;
            this.OfferId = offerId;
            this.RentalData = rentalData;
        }
    }
}
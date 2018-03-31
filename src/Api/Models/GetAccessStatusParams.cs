namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GetAccessStatusParams: IRequestMessage
    {
        [JsonProperty("customerToken")]
        public string CustomerToken { get; set; }
        [JsonProperty("offerId")]
        public string OfferId { get; set; }
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        public GetAccessStatusParams()
        {

        }

        public GetAccessStatusParams(string customerToken, string offerId, string ipAddress)
        {
            this.CustomerToken = customerToken;
            this.OfferId = offerId;
            this.IpAddress = ipAddress;
        }
    }
}
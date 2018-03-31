namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GetCustomerParams: IRequestMessage
    {
        [JsonProperty("customerToken")]
        public string CustomerToken { get; set; }

        public GetCustomerParams()
        {

        }

        public GetCustomerParams(string customerToken)
        {
            this.CustomerToken = customerToken;
        }
    }
}
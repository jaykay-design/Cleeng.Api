namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class IpAddressParams: IRequestMessage
    {
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        public IpAddressParams()
        {

        }

        public IpAddressParams(string ipAddress)
        {
            this.IpAddress = ipAddress;
        }
    }
}
namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GetAccessStatusForDeviceParams : IRequestMessage
    {
        [JsonProperty("customerToken")]
        public string CustomerToken { get; set; }
        [JsonProperty("offerId")]
        public string OfferId { get; set; }
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        public GetAccessStatusForDeviceParams(string customerToken,
                                              string offerId,
                                              string deviceId,
                                              string deviceType)
        {
            this.CustomerToken = customerToken;
            this.OfferId = offerId;
            this.DeviceId = deviceId;
            this.DeviceType = deviceType;
        }
    }
}
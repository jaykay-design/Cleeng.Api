namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class PrepareRemoteAuthParams: IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }
        [JsonProperty("customerData")]
        public CustomerData CustomerData { get; set; }
        [JsonProperty("flowDescription", NullValueHandling = NullValueHandling.Ignore)]
        public FlowDescription flowDescription { get; set; }

        public PrepareRemoteAuthParams()
        {

        }

        public PrepareRemoteAuthParams(string publisherToken,
                                        CustomerData customerData,
                                        FlowDescription flowDescription)
        {
            this.PublisherToken = publisherToken;
            this.CustomerData = customerData;
            this.flowDescription = flowDescription;
        }
    }
}
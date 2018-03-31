namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class GenerateMyAccountUrlParams : IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("modules")]
        public List<string> Modules { get; set; }

        public GenerateMyAccountUrlParams(string publisherToken, string customerEmail, List<string> modules)
        {
            this.PublisherToken = publisherToken;
            this.CustomerEmail = customerEmail;
            this.Modules = modules;
        }

        public GenerateMyAccountUrlParams(string customerEmail, List<string> modules)
        {
            this.CustomerEmail = customerEmail;
            this.Modules = modules;
        }
    }
}
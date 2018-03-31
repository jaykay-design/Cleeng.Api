namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GetCustomerResult : IResultMessage
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class TokenResult : IResultMessage
    {
       [JsonProperty("token")]
       public string Token { get; set; }
    }
}
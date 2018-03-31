namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class BoolResult : IResultMessage
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}

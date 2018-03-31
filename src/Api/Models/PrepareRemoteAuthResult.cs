namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class PrepareRemoteAuthResult : IResultMessage
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        public PrepareRemoteAuthResult(string url)
        {
            this.Url = url;
        }

        public PrepareRemoteAuthResult()
        {

        }
    }
}
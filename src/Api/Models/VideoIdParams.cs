namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class VideoIdParams
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }
        [JsonProperty("videoId")]
        public string VideoId { get; set; }

        public VideoIdParams(string publisherToken, string videoId)
        {
            this.PublisherToken = publisherToken;
            this.VideoId = videoId;
        }

        public VideoIdParams(string videoId)
        {
            this.VideoId = videoId;
        }
    }
}
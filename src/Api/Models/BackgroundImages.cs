namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class BackgroundImages
    {
        [JsonProperty("small")]
        public string Small { get; set; }
        [JsonProperty("medium")]
        public string Medium { get; set; }
        [JsonProperty("Large")]
        public string Large { get; set; }

        public BackgroundImages(string small, string medium, string large)
        {
            this.Small = small;
            this.Medium = medium;
            this.Large = large;
        }

        public BackgroundImages()
        {

        }
    }
}
namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class BackgroundImages
    {
        [JsonProperty("small", NullValueHandling = NullValueHandling.Ignore)]
        public string Small { get; set; }
        [JsonProperty("medium", NullValueHandling = NullValueHandling.Ignore)]
        public string Medium { get; set; }
        [JsonProperty("Large", NullValueHandling = NullValueHandling.Ignore)]
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
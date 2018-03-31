namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class ListParams : IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }
        [JsonProperty("criteria")]
        public Criteria Criteria { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("limit")]
        public int Limit { get; set; }

        public ListParams()
        {
            this.Criteria = new Criteria();
            this.Offset = 0;
            this.Limit = 25;

        }
        public ListParams(string publisherToken, Criteria criteria, int offset = 0, int limit = 25)
        {
            this.PublisherToken = publisherToken;
            this.Criteria = criteria;
            this.Offset = offset;
            this.Limit = limit;
        }
    }
}
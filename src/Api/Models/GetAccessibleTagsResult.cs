namespace Cleeng.Api.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class GetAccessibleTagsResult: IResultMessage
    {
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
    }
}

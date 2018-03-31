namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class ListResult<T>: IResultMessage
    {
        [JsonProperty("items")]
        public List<T> Items { get; set; }

        [JsonProperty("totalItemCount")]
        public int TotalItemCount { get; set; }
    }
}
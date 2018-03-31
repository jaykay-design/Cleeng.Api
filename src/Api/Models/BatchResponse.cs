namespace Cleeng.Api.Models
{
    using Newtonsoft.Json.Linq;
    using System.Collections.Generic;

    internal class BatchResponse
    {
        public List<JObject> responses = new List<JObject>();
    }
}

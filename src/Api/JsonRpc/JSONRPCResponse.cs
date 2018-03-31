namespace Cleeng.Api.JsonRpc
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JSONRPCResponse<T> : JSONRPCMessage where T : IResultMessage
    {
        [JsonProperty("result")]
        public T Result { get; set; }

        public JSONRPCResponse()
        {

        }
    }
}

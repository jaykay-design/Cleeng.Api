namespace Cleeng.Api.JsonRpc
{
    using Newtonsoft.Json;
    using System;

    public abstract class JSONRPCMessage
    {
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public Error Error { get; set; }

        public JSONRPCMessage()
        {
            this.Id = Guid.NewGuid().ToString();
            this.JsonRpc = "2.0";
        }

        internal JSONRPCMessage(string id, string jsonrpc, Error error = null)
        {
            this.Id = string.IsNullOrEmpty(id) ? Guid.NewGuid().ToString() : id;
            this.JsonRpc = jsonrpc;
            this.Error = error;
        }
    }
}

namespace Cleeng.Api.JsonRpc
{
    using Newtonsoft.Json;
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    public abstract class JSONRPCRequest<TRequest, TResult> : JSONRPCMessage
        where TRequest : IRequestMessage
        where TResult : IResultMessage
    {
        [JsonProperty("method")]
        public string Method { get; private set; }
        [JsonProperty("params")]
        public TRequest Parameters { get; private set; }

        internal Type ResultType { get; private set; }

        public JSONRPCRequest(string method, TRequest parameters = default(TRequest), string requestId = null, string jsonRpcVersion = "2.0")
            : base(requestId, jsonRpcVersion)
        {
            this.Method = method;
            this.Parameters = parameters;
            this.ResultType = typeof(TResult);
        }

        /// <summary>
        /// Executes this JSONRPC call
        /// </summary>
        /// <param name="useSandbox">Set to true if the Cleeng API sandbox must be used</param>
        /// <returns></returns>
        /// <exception cref="System.AggregateException">Contains an ApiException if the Cleeng API responsed with an error message. 
        /// See the exception's Message, Code and Data properties for details.</exception>
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS
        //  failure, server certificate validation or timeout.</exception>
        public async Task<TResult> ExecuteAsync(bool useSandbox = false)
        {
            var body = JsonConvert.SerializeObject(this);

            using (var client = new HttpClient())
            using (var postContent = new StringContent(body))
            using (var response = await client.PostAsync(
                useSandbox ? JSONRPCUrl.sandboxApiUrl : JSONRPCUrl.liveApiUrl,
                postContent))
            {

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new ApiException("Cleeng API error", ErrorCodes.APIError, response.ReasonPhrase);
                }

                var responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<JSONRPCResponse<TResult>>(responseBody);

                if (result.Error != null)
                {
                    throw new ApiException(result.Error.Message, (ErrorCodes)result.Error.Code, result.Error.Data);
                }

                return result.Result;
            }
        }

        public void AddToBatch(JSONRPCBatchRequest batch)
        {
            batch.AddToBatch<TResult>(this, this.Id);
        }
    }
}

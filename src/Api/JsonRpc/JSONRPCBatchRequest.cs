namespace Cleeng.Api.JsonRpc
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Models;
    using System.Linq;
    using System;
    using Newtonsoft.Json.Linq;

    public class JSONRPCBatchRequest
    {
        private List<object> requests;
        private List<string> ids;
        private List<Type> responseTypes;

        /// <summary>
        /// Received responses in the same order as the requests were added. Responses with errors are null.
        /// </summary>
        public List<IResultMessage> Responses { get; private set; }
        /// <summary>
        /// Received errors in the same order as the requests were added. Responses without errors are null.
        /// </summary>
        public List<Error> Errors { get; private set; }

        public int TotalRequest
        {
            get
            {
                return requests.Count;
            }
        }

        public JSONRPCBatchRequest(string jsonRpcVersion = "2.0")
        {
            this.Responses = new List<IResultMessage>();
            this.Errors = new List<Error>();

            this.requests = new List<object>();
            this.ids = new List<string>();
            this.responseTypes = new List<Type>();
        }

        /// <summary>
        /// Executes the JSONRPC call in property Requests. All responses are available in property Responses.
        /// </summary>
        /// <param name="useSandbox">Set to true if the Cleeng API sandbox must be used</param>
        /// <returns>true if all requests were successfull</returns>
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS
        ///  failure, server certificate validation or timeout.</exception>
        /// <exception cref="ApiException"></exception>
        public async Task<bool> ExecuteAsync(bool useSandbox = false)
        {
            var body = JsonConvert.SerializeObject(this.requests);

            using (var client = new HttpClient())
            using (var postContent = new StringContent(body))
            using (var response = await client.PostAsync(
                useSandbox ? JSONRPCUrl.sandboxApiUrl : JSONRPCUrl.liveApiUrl,
                postContent))
            {
                var responseBody = await response.Content.ReadAsStringAsync();

                if (responseBody.StartsWith("{"))
                {
                    var error = JsonConvert.DeserializeObject<Error>(responseBody);
                    throw new ApiException(error);
                }

                var result = JsonConvert.DeserializeObject<List<JObject>>(responseBody);

                foreach (var item in result)
                {
                    var baseItem = item.ToObject<JSONRPCMessage>();
                    if (baseItem.Error == null)
                    {
                        var resultType = this.responseTypes[this.ids.IndexOf(baseItem.Id)];
                        var resultObject = item.SelectToken("result");
                        this.Responses.Add((IResultMessage)resultObject.ToObject(resultType));
                        this.Errors.Add(null);
                    }
                    else
                    {
                        this.Errors.Add(baseItem.Error);
                        this.Responses.Add(null);
                    }
                }

                return this.Errors.Any(e => e != null);
            }
        }

        internal void AddToBatch<TResult>(object message, string id)
            where TResult : IResultMessage
        {
            this.requests.Add(message);
            this.ids.Add(id);
            this.responseTypes.Add(typeof(TResult));
        }
    }
}

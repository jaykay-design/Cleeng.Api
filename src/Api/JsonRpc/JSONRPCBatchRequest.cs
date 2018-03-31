namespace Cleeng.Api.JsonRpc
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Models;
    using System.Linq;

    public class JSONRPCBatchRequest
    {
        public List<JSONRPCRequest<IRequestMessage, IResultMessage>> Requests { get; private set; }
        public List<JSONRPCResponse<IResultMessage>> Responses { get; private set; }

        public JSONRPCBatchRequest(string jsonRpcVersion = "2.0")
        {
            this.Requests = new List<JSONRPCRequest<IRequestMessage, IResultMessage>>();
            this.Responses = new List<JSONRPCResponse<IResultMessage>>();
        }

        /// <summary>
        /// Executes the JSONRPC call in property Requests. All responses are available in property Responses.
        /// </summary>
        /// <param name="useSandbox">Set to true if the Cleeng API sandbox must be used</param>
        /// <returns>true if all requests were successfull</returns>
        /// <exception cref="System.Net.Http.HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS
        //  failure, server certificate validation or timeout.</exception>
        public async Task<bool> ExecuteAsync(bool useSandbox = false)
        {
            var batch = new BatchRequest();
            batch.Requests.AddRange(this.Requests);

            var body = JsonConvert.SerializeObject(batch);

            using (var client = new HttpClient())
            using (var postContent = new StringContent(body))
            using (var response = await client.PostAsync(
                useSandbox ? JSONRPCUrl.sandboxApiUrl : JSONRPCUrl.liveApiUrl,
                postContent))
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<BatchResponse>(responseBody);

                foreach(var item in result.responses)
                {
                    var baseItem = item.ToObject<JSONRPCMessage>();
                    var resultType = this.Requests.First(r => r.Id == baseItem.Id).ResultType;

                    this.Responses.Add((JSONRPCResponse<IResultMessage>)item.ToObject(resultType));
                }

                return !this.Responses.Any(r => r.Error != null);
            }
        }
    }
}

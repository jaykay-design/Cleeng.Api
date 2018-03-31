namespace Cleeng.Api.Models
{
    using JsonRpc;
    using System.Collections.Generic;

    internal class BatchRequest
    {
        public List<JSONRPCRequest<IRequestMessage, IResultMessage>> Requests { get; private set; }

        public BatchRequest()
        {
            this.Requests = new List<JSONRPCRequest<IRequestMessage, IResultMessage>>();
        }
    }
}
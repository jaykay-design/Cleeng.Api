namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GetAccessStatusRequest : JSONRPCRequest<GetAccessStatusParams, GetAccessStatusResult>
    {
        public GetAccessStatusRequest(GetAccessStatusParams parameters)
            : base("getAccessStatus", parameters)
        { }
    }
}

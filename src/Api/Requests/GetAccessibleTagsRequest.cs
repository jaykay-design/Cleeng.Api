namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GetAccessibleTagsRequest : JSONRPCRequest<GetAccessibleTagsParams, GetAccessibleTagsResult>
    {
        public GetAccessibleTagsRequest(GetAccessibleTagsParams parameters)
            : base("getAccessibleTags", parameters)
        { }
    }
}
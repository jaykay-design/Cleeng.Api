namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GenerateMyAccountUrlRequest : JSONRPCRequest<GenerateMyAccountUrlParams, UrlResult>
    {
        public GenerateMyAccountUrlRequest(GenerateMyAccountUrlParams parameters) 
            : base("generateMyAccountUrl", parameters)
        { }
    }
}

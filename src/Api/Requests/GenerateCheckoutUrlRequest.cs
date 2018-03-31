namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GenerateCheckoutUrlRequest : JSONRPCRequest<GenerateCheckoutUrlParams, UrlResult>
    {
        public GenerateCheckoutUrlRequest(GenerateCheckoutUrlParams parameters) 
            : base("generateCheckoutUrl", parameters)
        { }
    }
}

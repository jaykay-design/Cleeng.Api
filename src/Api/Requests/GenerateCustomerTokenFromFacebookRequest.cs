namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GenerateCustomerTokenFromFacebookRequest : JSONRPCRequest<GenerateCustomerTokenFromFacebookParams, TokenResult>
    {
        public GenerateCustomerTokenFromFacebookRequest(GenerateCustomerTokenFromFacebookParams parameters) 
            : base("generateCustomerTokenFromFacebook", parameters)
        { }
    }
}

namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GenerateCustomerTokenRequest : JSONRPCRequest<GenerateCustomerTokenParams, TokenResult>
    {
        public GenerateCustomerTokenRequest(GenerateCustomerTokenParams parameters) 
            : base("generateCustomerToken", parameters)
        { }
    }
}

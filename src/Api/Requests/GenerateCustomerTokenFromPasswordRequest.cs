namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GenerateCustomerTokenFromPasswordRequest : JSONRPCRequest<GenerateCustomerTokenFromPasswordParams, TokenResult>
    {
        public GenerateCustomerTokenFromPasswordRequest(GenerateCustomerTokenFromPasswordParams parameters) 
            : base("generateCustomerTokenFromPassword", parameters)
        { }
    }
}

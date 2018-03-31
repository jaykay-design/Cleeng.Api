namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GenerateCustomerTokenFromTransactionIdRequest : JSONRPCRequest<GenerateCustomerTokenFromTransactionIdParams, TokenResult>
    {
        public GenerateCustomerTokenFromTransactionIdRequest(GenerateCustomerTokenFromTransactionIdParams parameters) 
            : base("generateCustomerTokenFromTransactionId", parameters)
        { }
    }
}

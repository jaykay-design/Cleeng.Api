namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GetCustomerRequest : JSONRPCRequest<GetCustomerParams, GetCustomerResult>
    {
        public GetCustomerRequest(GetCustomerParams parameters)
            : base("getCustomer", parameters)
        { }
    }
}
namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class UpdateCustomerEmailRequest : JSONRPCRequest<UpdateCustomerEmailParams, BoolResult>
    {
        public UpdateCustomerEmailRequest(UpdateCustomerEmailParams parameters)
            : base("updateCustomerEmail", parameters)
        { }
    }
}

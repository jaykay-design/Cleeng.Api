namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class UpdateCustomerSubscriptionRequest : JSONRPCRequest<UpdateCustomerSubscriptionParams, CustomerSubscription>
    {
        public UpdateCustomerSubscriptionRequest(UpdateCustomerSubscriptionParams parameters) 
            : base("updateCustomerSubscription", parameters)
        { }
    }
}

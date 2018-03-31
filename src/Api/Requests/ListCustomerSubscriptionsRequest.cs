namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class ListCustomerSubscriptionsRequest : JSONRPCRequest<ListCustomerSubscriptionsParams, ListResult<CustomerSubscription>>
    {
        public ListCustomerSubscriptionsRequest(ListCustomerSubscriptionsParams parameters)
            : base("listCustomerSubscriptions", parameters)
        { }
    }
}

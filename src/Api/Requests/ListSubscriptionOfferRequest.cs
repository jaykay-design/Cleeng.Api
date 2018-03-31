namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class ListSubscriptionOfferRequest : JSONRPCRequest<ListParams, ListResult<SubscriptionOfferResult>>
    {
        public ListSubscriptionOfferRequest(ListParams parameters)
            : base("listSubscriptionOffers", parameters)
        { }
    }
}

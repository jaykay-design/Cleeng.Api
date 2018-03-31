namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GetSubscriptionOfferRequest : JSONRPCRequest<GetOfferParams, SubscriptionOfferResult>
    {
        public GetSubscriptionOfferRequest(GetOfferParams parameters)
            : base("getSubscriptionOffer", parameters)
        { }
    }
}

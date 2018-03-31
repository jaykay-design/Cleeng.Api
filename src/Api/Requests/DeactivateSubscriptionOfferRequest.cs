namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class DeactivateSubscriptionOfferRequest : JSONRPCRequest<DeactivateOfferParams, SubscriptionOfferResult>
    {
        public DeactivateSubscriptionOfferRequest(DeactivateOfferParams parameters)
            : base("deactivateSubscriptionOffer", parameters)
        { }
    }
}

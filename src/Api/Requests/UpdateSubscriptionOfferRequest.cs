namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class UpdateSubscriptionOfferRequest : JSONRPCRequest<UpdateOfferParams<SubscriptionOfferData>, SubscriptionOfferResult>
    {
        public UpdateSubscriptionOfferRequest(UpdateOfferParams<SubscriptionOfferData> parameters)
            :base("updateSubscriptionOffer", parameters)
        { }
    }
}

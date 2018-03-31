namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class CreateSubscriptionOfferRequest : JSONRPCRequest<CreateOfferParams<SubscriptionOfferData>, SubscriptionOfferResult>
    {
        public CreateSubscriptionOfferRequest(CreateOfferParams<SubscriptionOfferData> parameters)
            : base("createSubscriptionOffer", parameters)
        {
        }
    }
}
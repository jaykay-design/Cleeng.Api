namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class CancelEventOfferRequest : JSONRPCRequest<DeactivateOfferParams, EventOfferResult>
    {
        public CancelEventOfferRequest(DeactivateOfferParams parameters)
            : base("cancelEventOffer", parameters)
        { }
    }
}

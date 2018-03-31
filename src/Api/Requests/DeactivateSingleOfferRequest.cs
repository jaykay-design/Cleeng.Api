namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class DeactivateSingleOfferRequest : JSONRPCRequest<DeactivateOfferParams, SingleOfferResult>
    {
        public DeactivateSingleOfferRequest(DeactivateOfferParams parameters)
            : base("deactivateSingleOffer", parameters)
        { }
    }
}

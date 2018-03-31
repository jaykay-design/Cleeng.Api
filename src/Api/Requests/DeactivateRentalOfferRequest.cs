namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class DeactivateRentalOfferRequest : JSONRPCRequest<DeactivateOfferParams, RentalOfferResult>
    {
        public DeactivateRentalOfferRequest(DeactivateOfferParams parameters)
            : base("deactivateRentalOffer", parameters)
        { }
    }
}

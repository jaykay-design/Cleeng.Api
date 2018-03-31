namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class DeactivatePassOfferRequest : JSONRPCRequest<DeactivateOfferParams, PassOfferResult>
    {
        public DeactivatePassOfferRequest(DeactivateOfferParams parameters)
            : base("deactivatePassOffer", parameters)
        { }
    }
}

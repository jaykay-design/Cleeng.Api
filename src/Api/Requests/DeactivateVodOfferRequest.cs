namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class DeactivateVodOfferRequest : JSONRPCRequest<GetVodOfferParams, VodOfferData>
    {
        public DeactivateVodOfferRequest(GetVodOfferParams parameters)
            : base("deactivateVodOffer", parameters)
        { }
    }
}

namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class UpdateVodOfferRequest : JSONRPCRequest<UpdateVodOfferParams, VodOfferResult>
    {
        public UpdateVodOfferRequest(UpdateVodOfferParams parameters)
            : base("updateVodOffer", parameters)
        { }
    }
}

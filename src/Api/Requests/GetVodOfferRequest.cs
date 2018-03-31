namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GetVodOfferRequest : JSONRPCRequest<GetVodOfferParams, VodOfferResult>
    {
        public GetVodOfferRequest(GetVodOfferParams parameters)
            : base("getVodOffer", parameters)
        { }
    }
}

namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GetPassOfferRequest : JSONRPCRequest<GetOfferParams, PassOfferResult>
    {
        public GetPassOfferRequest(GetOfferParams parameters)
            : base("getPassOffer", parameters)
        { }
    }
}

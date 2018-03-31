namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GetSingleOfferRequest : JSONRPCRequest<GetOfferParams, SingleOfferResult>
    {
        public GetSingleOfferRequest(GetOfferParams parameters)
            : base("getSingleOffer", parameters)
        { }
    }
}

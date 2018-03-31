namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GetRentalOfferRequest : JSONRPCRequest<GetOfferParams, RentalOfferResult>
    {
        public GetRentalOfferRequest(GetOfferParams parameters)
            : base("getRentalOffer", parameters)
        { }
    }
}

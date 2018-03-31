namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class ListRentalOfferRequest : JSONRPCRequest<ListParams, ListResult<RentalOfferResult>>
    {
        public ListRentalOfferRequest(ListParams parameters)
            : base("listRentalOffers", parameters)
        { }
    }
}

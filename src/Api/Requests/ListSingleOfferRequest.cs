namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class ListSingleOfferRequest : JSONRPCRequest<ListParams, ListResult<SingleOfferResult>>
    {
        public ListSingleOfferRequest(ListParams parameters)
            : base("listSingleOffers", parameters)
        { }
    }
}

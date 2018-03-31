namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class ListPassOfferRequest : JSONRPCRequest<ListParams, ListResult<PassOfferResult>>
    {
        public ListPassOfferRequest(ListParams parameters)
            : base("listPassOffers", parameters)
        { }
    }
}

namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class ListEventOfferRequest : JSONRPCRequest<ListParams, ListResult<EventOfferResult>>
    {
        public ListEventOfferRequest(ListParams parameters)
            : base("listEventOffers", parameters)
        { }
    }
}

namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class ListVodOfferRequest : JSONRPCRequest<ListParams, ListResult<Vod>>
    {
        public ListVodOfferRequest(ListParams parameters)
            : base("listVodOffers", parameters)
        { }
    }
}

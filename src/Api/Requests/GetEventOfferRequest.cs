namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GetEventOfferRequest : JSONRPCRequest<GetOfferParams, EventOfferResult>
    {
        public GetEventOfferRequest(GetOfferParams parameters)
            : base("getEventOffer", parameters)
        { }
    }
}

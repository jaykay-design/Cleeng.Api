namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class UpdateEventOfferRequest : JSONRPCRequest<UpdateOfferParams<EventOfferData>, EventOfferResult>
    {
        public UpdateEventOfferRequest(UpdateOfferParams<EventOfferData> parameters)
            : base("updateEventOffer", parameters)
        { }
    }
}

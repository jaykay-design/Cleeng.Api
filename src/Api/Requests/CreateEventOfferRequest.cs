namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class CreateEventOfferRequest : JSONRPCRequest<CreateOfferParams<EventOfferData>, EventOfferResult>
    {
        public CreateEventOfferRequest(CreateOfferParams<EventOfferData> parameters)
            : base("createEventOffer", parameters)
        { }
    }
}

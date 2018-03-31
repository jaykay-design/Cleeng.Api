namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class CreateSingleOfferRequest : JSONRPCRequest<CreateOfferParams<SingleOfferData>, SingleOfferResult>
    {
        public CreateSingleOfferRequest(CreateOfferParams<SingleOfferData> parameters)
            : base("createSingleOffer", parameters)
        {
        }
    }
}
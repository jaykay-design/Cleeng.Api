namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class CreateRentalOfferRequest : JSONRPCRequest<CreateOfferParams<RentalOfferData>, RentalOfferResult>
    {
        public CreateRentalOfferRequest(CreateOfferParams<RentalOfferData> parameters)
            : base("createRentalOffer", parameters)
        {
        }
    }
}
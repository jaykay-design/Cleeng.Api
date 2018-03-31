namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class UpdateRentalOfferRequest : JSONRPCRequest<UpdateOfferParams<RentalOfferData>, RentalOfferResult>
    {
        public UpdateRentalOfferRequest(UpdateOfferParams<RentalOfferData> parameters)
            :base("updateRentalOffer", parameters)
        { }
    }
}

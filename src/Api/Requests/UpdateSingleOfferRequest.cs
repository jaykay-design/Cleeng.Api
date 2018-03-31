namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class UpdateSingleOfferRequest : JSONRPCRequest<UpdateOfferParams<SingleOfferData>, SingleOfferResult>
    {
        public UpdateSingleOfferRequest(UpdateOfferParams<SingleOfferData> parameters)
            :base("updateSingleOffer", parameters)
        { }
    }
}

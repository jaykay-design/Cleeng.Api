namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class UpdatePassOfferRequest : JSONRPCRequest<UpdateOfferParams<PassOfferData>, PassOfferResult>
    {
        public UpdatePassOfferRequest(UpdateOfferParams<PassOfferData> parameters)
            :base("updatePassOffer", parameters)
        { }
    }
}

namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class CreateVodOfferRequest : JSONRPCRequest<CreateOfferParams<VodOfferData>, VodOfferResult>
    {
        public CreateVodOfferRequest(CreateOfferParams<VodOfferData> parameters)
            : base("createVodOffer", parameters)
        { }
    }
}

namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class CreatePassOfferRequest : JSONRPCRequest<CreateOfferParams<PassOfferData>, PassOfferResult>
    {
        public CreatePassOfferRequest(CreateOfferParams<PassOfferData> parameters)
            : base("createPassOffer", parameters)
        {
        }
    }
}
namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class UpdateCustomerRentalRequest : JSONRPCRequest<UpdateCustomerRentalParams, RentalResult>
    {
        public UpdateCustomerRentalRequest(UpdateCustomerRentalParams parameters) 
            : base("updateCustomerRental", parameters)
        { }
    }
}

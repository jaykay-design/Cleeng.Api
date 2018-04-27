namespace Cleeng.Api.JsonRpc
{
    using System.ComponentModel;

    public enum ErrorCodes
    {
        [Description("Customer token cannot be empty/Customer token is invalid")]
        CustomerTokenInvalid = 1,
        [Description("Publisher token cannot be empty/Publisher token is invalid")]
        PublisherTokenMissing = 3,
        [Description("Offer offerId does not exist")]
        OfferIdNotFound = 4,
        [Description("Enterprise account is required to call this API")]
        RequiresEnterpriseAccount = 5,
        [Description("User customerEmail does not exist/Customer customerEmail is not associated with your account or doesn't exist/customerEmail is not valid e-mail address")]
        CustomerEmailError = 10,
        [Description("E-mail address is required/Invalid customerData/Password is missing")]
        EmailRequired_InvalidCustomerData_PasswordMissing = 11,
        [Description("Customer account is inactive")]
        AccountInactive = 12,
        [Description("Customer already exists")]
        CustomerAlreadyExists = 13,
        [Description("Ip address limit exceeded")]
        ToManyDifferentIPAddresses = 14,
        [Description("Invalid customer credentials")]
        InvalidCustomerCredentials = 15,
        [Description("ResetPasswordToken is not valid or has expired/resetUrl is not valid URL.")]
        ResetParamsNotValid = 16,

        [Description("Generic API error")]
        APIError = 999
    }
}

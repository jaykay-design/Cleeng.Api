namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GetLocaleDataFromIPRequest : JSONRPCRequest<IpAddressParams, LocaleDataResult>
    {
        public GetLocaleDataFromIPRequest(IpAddressParams parameters)
            : base("getLocaleDataFromIp", parameters)
        { }
    }
}

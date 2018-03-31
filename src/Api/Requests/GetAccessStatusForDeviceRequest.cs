namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;

    public class GetAccessStatusForDeviceRequest : JSONRPCRequest<GetAccessStatusForDeviceParams, GetAccessStatusForDeviceResult>
    {
        public GetAccessStatusForDeviceRequest(GetAccessStatusForDeviceParams parameters)
            : base("getAccessStatusForDevice", parameters)
        { }
    }
}

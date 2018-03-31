namespace Cleeng.Api.Requests
{
    using JsonRpc;
    using Models;
    using System;

    [Obsolete("This method is depreciated. We strongly recommend to use GenerateCheckoutUrl method instead.")]
    public class PrepareRemoteAuthRequest : JSONRPCRequest<PrepareRemoteAuthParams, PrepareRemoteAuthResult>
    {
        public PrepareRemoteAuthRequest(PrepareRemoteAuthParams parameters) 
            : base("prepareRemoteAuth", parameters)
        { }
    }
}
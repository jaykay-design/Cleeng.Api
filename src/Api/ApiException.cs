﻿namespace Cleeng.Api
{
    using Cleeng.Api.JsonRpc;
    using System;

    public class ApiException: Exception
    {
        public string ResponseBody { get; set; }
        public ErrorCodes ErrorCode { get; set; }
        public object ErrorData { get; set; }

        public ApiException(Error apiError)
            : base(apiError.Message)
        {
            this.ErrorCode = (ErrorCodes)apiError.Code;
            this.ErrorData = apiError.Data;
        }

        public ApiException(string message, ErrorCodes code, object data)
            :base(message)
        {
            this.ErrorCode = code;
            this.ErrorData = data;
        }
    }
}

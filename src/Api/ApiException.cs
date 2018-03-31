namespace Cleeng.Api
{
    using System;

    public class ApiException: Exception
    {
        public string ResponseBody { get; set; }
        public int ErrorCode { get; set; }
        public object ErrorData { get; set; }

        public ApiException(string message, int code, object data)
            :base(message)
        {
            this.ErrorCode = code;
            this.ErrorData = data;
        }
    }
}

# Getting started
1. Obtain your API key
   Go to your [Cleen dashboard](https://cleeng.com/amazing-dashboard/api-keys) and create an API key.

2. Add the package
   Include the library in to your project using the [nuGet package manager](https://docs.microsoft.com/en-us/nuget/what-is-nuget)
   ``` nuget install Cleeng.Api ```


## Using the library
Each Cleeng API call has its own request class which expects the required parameters in the contructor.
Once the class is instantanited call the ExecuteAsync method.

```C#
namespace MyApp
{
    using Cleeng.Api.Models;
    using Cleeng.Api.Requests;

    class Program
    {
        static void Main(string[] args)
        {
            string publisherToken = "[your API key goes here]";

            var request = new GetLocaleDataFromIPRequest(new IpAddressParams() { IpAddress = "140.11.256.111" });
            var result = request.ExecuteAsync().Result;

			...
        }
    }
}
```

To execute multiple calls at once use the JSONRPCBatchRequest class instead.

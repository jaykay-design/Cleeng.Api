namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GenerateCustomerTokenFromTransactionIdParams : IRequestMessage
    {
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }
}

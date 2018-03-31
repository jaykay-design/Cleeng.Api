namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class BaseOfferDataForRequests : BaseOfferData
    {
        [JsonProperty("associateEmail")]
        public string AssociateEmail { get; set; }

        public BaseOfferDataForRequests()
        {

        }
    }
}
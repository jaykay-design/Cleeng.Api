namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class BaseOfferDataForRequests : BaseOfferData
    {
        [JsonProperty("associateEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateEmail { get; set; }

        public BaseOfferDataForRequests()
        {

        }
    }
}
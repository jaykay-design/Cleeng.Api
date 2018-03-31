namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class EventOfferDataForRequests : EventOfferData
    {
        [JsonProperty("backgroundImageUrl")]
        public string BackgroundImageUrl { get; set; }
    }
}
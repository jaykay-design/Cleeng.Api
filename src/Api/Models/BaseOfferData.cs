namespace Cleeng.Api.Models
{
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class BaseOfferData
    {
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("geoRestrictionEnabled")]
        public bool GeoRestrictionEnabled { get; set; }
        [JsonProperty("geoRestrictionType")]
        public string GeoRestrictionType { get; set; }
        [JsonProperty("geoRestrictionCountries")]
        public List<string> GeoRestrictionCountries { get; set; }

        [JsonProperty("membershipOnly")]
        public bool MembershipOnly { get; set; }
        [JsonProperty("createdAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updatedAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime UpdatedAt { get; set; }

    }
}
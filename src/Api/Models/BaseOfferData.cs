namespace Cleeng.Api.Models
{
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class BaseOfferData
    {
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public double Price { get; set; }
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("geoRestrictionEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool GeoRestrictionEnabled { get; set; }
        [JsonProperty("geoRestrictionType", NullValueHandling = NullValueHandling.Ignore)]
        public string GeoRestrictionType { get; set; }
        [JsonProperty("geoRestrictionCountries", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GeoRestrictionCountries { get; set; }

        [JsonProperty("membershipOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool MembershipOnly { get; set; }
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CreatedAt { get; set; }
        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? UpdatedAt { get; set; }

    }
}
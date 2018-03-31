namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class CustomerData
    {

        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("facebookId")]
        public string FacebookId { get; set; }

        public CustomerData()
        {

        }

        public CustomerData(string email,
                            string locale,
                            string currency,
                            string country)
        {
            this.Email = email;
            this.Locale = locale;
            this.Currency = currency;
            this.Country = country;
        }

        public CustomerData(string email,
                            string locale,
                            string currency,
                            string country,
                            string password)
        {
            this.Email = email;
            this.Locale = locale;
            this.Currency = currency;
            this.Country = country;
            this.Password = password;
        }

        public CustomerData(string email,
                            string locale,
                            string currency,
                            string country,
                            string password,
                            string facebookId)
        {
            this.Email = email;
            this.Locale = locale;
            this.Currency = currency;
            this.Country = country;
            this.Password = password;
            this.FacebookId = facebookId;
        }
    }
}
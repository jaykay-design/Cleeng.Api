namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class ResetPasswordParams
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("resetPasswordToken")]
        public string ResetPasswordToken { get; set; }

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }

        public ResetPasswordParams(string publisherToken, string customerEmail, string resetPasswordToken, string newPassword)
        {

            this.PublisherToken = publisherToken;
            this.CustomerEmail = customerEmail;
            this.ResetPasswordToken = resetPasswordToken;
            this.NewPassword = newPassword;
        }

        public ResetPasswordParams(string customerEmail, string resetPasswordToken, string newPassword)
        {
            this.CustomerEmail = customerEmail;
            this.ResetPasswordToken = resetPasswordToken;
            this.NewPassword = newPassword;
        }
    }
}
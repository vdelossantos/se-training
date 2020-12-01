namespace Orders.Api.Messages.Orders.Requests
{
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class AddOrderWebRequest : WebRequest
    {
        [JsonProperty("senderEmail")]
        [Required]
        public string SenderEmail { get; set; }

        [JsonProperty("senderName")]
        [Required]
        public string SenderName { get; set; }

        [JsonProperty("recipientEmail")]
        [Required]
        public string RecipientEmail { get; set; }

        [JsonProperty("recipientName")]
        [Required]
        public string RecipientName { get; set; }

        [JsonProperty("voucher")]
        [Required]
        public string Voucher { get; set; }

        [JsonProperty("dedication")]
        public string Dedication { get; set; }
    }
}

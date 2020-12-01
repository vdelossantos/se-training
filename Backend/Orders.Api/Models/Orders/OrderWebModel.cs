namespace Orders.Api.Models.Orders
{
    using System;
    using Newtonsoft.Json;

    public class OrderWebModel
    {
        [JsonProperty("senderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("senderName")]
        public string SenderName { get; set; }

        [JsonProperty("recipientEmail")]
        public string RecipientEmail { get; set; }

        [JsonProperty("recipientName")]
        public string RecipientName { get; set; }

        [JsonProperty("voucher")]
        public string Voucher { get; set; }

#nullable enable
        [JsonProperty("dedication")]
        public string? Dedication { get; set; }
#nullable disable

        [JsonProperty("orderDate")]
        public DateTime OrderDate { get; set; }
    }
}

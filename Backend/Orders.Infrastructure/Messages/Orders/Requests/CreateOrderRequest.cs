namespace Orders.Infrastructure.Messages.Orders.Requests
{
    using System.Runtime.Serialization;

    [DataContract]
    public class CreateOrderRequest
    {
        [DataMember]
        public string SenderEmail { get; set; }

        [DataMember]
        public string SenderName { get; set; }

        [DataMember]
        public string RecipientEmail { get; set; }

        [DataMember]
        public string RecipientName { get; set; }

        [DataMember]
        public string Voucher { get; set; }

        [DataMember]
#nullable enable
        public string? Dedication { get; set; }
#nullable disable
    }
}
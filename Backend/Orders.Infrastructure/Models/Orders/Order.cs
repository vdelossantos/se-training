namespace Orders.Infrastructure.Models.Orders
{
    using System;
    using System.Runtime;
    using System.Runtime.Serialization;

    [DataContract]
    public class Order
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

#nullable enable
        [DataMember]
        public string? Dedication { get; set; }
#nullable disable

        [DataMember]
        public DateTime OrderDate { get; set; }
    }
}

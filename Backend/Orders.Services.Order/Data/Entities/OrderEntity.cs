namespace Orders.Services.Order.Data.Entities
{
    using System;

    public class OrderEntity
    {
        public string SenderEmail { get; set; }

        public string SenderName { get; set; }

        public string RecipientEmail { get; set; }

        public string RecipientName { get; set; }

        public string Voucher { get; set; }

        public string Dedication { get; set; }

        public DateTime OrderDate { get; set; }
    }
}

namespace Orders.Services.Order.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using Orders.Infrastructure.Messages.Orders.Requests;
    using Orders.Infrastructure.Models.Orders;
    using Orders.Services.Order.Data.Entities;

    public static class OrderExtensions
    {
        public static OrderEntity AsEntity(this CreateOrderRequest request)
        {
            var result = new OrderEntity
            {
                SenderEmail = request.SenderEmail,
                SenderName = request.SenderName,
                RecipientEmail = request.RecipientEmail,
                RecipientName = request.RecipientName,
                Voucher = request.Voucher,
                Dedication = request.Dedication
            };

            return result;
        }

        public static IEnumerable<Order> AsModel(this IEnumerable<OrderEntity> entities)
        {
            var result = entities.Select(entity => entity.AsModel());
            return result;
        }

        public static Order AsModel(this OrderEntity entity)
        {
            var result = new Order
            {
                SenderEmail = entity.SenderEmail,
                SenderName = entity.SenderName,
                RecipientEmail = entity.RecipientEmail,
                RecipientName = entity.RecipientName,
                Voucher = entity.Voucher,
                Dedication = entity.Dedication,
                OrderDate = entity.OrderDate
            };

            return result;
        }
    }
}

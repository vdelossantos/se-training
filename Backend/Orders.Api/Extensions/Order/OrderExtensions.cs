namespace Orders.Api.Extensions.Order
{
    using System.Collections.Generic;
    using System.Linq;
    using Orders.Api.Messages;
    using Orders.Api.Messages.Orders.Requests;
    using Orders.Api.Models.Orders;
    using Orders.Infrastructure.Messages.Orders.Requests;
    using Orders.Infrastructure.Messages.Orders.Responses;
    using Orders.Infrastructure.Models.Orders;

    public static class OrderExtensions
    {
        public static CreateOrderRequest AsRequest(this AddOrderWebRequest request)
        {
            var result = new CreateOrderRequest
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

        public static WebResponse AsWebResponse(this CreateOrderResponse response)
        {
            var result = new WebResponse
            {
                Message = response.Message,
                ErrorCode = response.ErrorCode,
                StatusCode = response.StatusCode
            };

            return result;
        }

        public static WebResponse<IEnumerable<OrderWebModel>> AsWebResponse(this GetOrdersResponse response)
        {
            var result = new WebResponse<IEnumerable<OrderWebModel>>(response.Data?.AsWebModel())
            {
                Message = response.Message,
                ErrorCode = response.ErrorCode,
                StatusCode = response.StatusCode
            };

            return result;
        }

        public static OrderWebModel AsWebModel(this Order model)
        {
            return new OrderWebModel
            {
                SenderEmail = model.SenderEmail,
                SenderName = model.SenderName,
                RecipientEmail = model.RecipientEmail,
                RecipientName = model.RecipientName,
                Voucher = model.Voucher,
                Dedication = model.Dedication,
                OrderDate = model.OrderDate.GetValueOrDefault()
            };
        }

        public static IEnumerable<OrderWebModel> AsWebModel(this IEnumerable<Order> models)
        {
            return models.Select(entity => entity.AsWebModel());
        }
    }
}

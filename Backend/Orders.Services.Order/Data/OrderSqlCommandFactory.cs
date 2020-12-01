namespace Orders.Services.Order.Data
{
    using System.Data;
    using System.Data.SqlClient;
    using Entities;

    public class OrderSqlCommandFactory : IOrderSqlCommandFactory
    {
        public SqlCommand CreateInsertOrderCommand(OrderEntity order)
        {
            var result = new SqlCommand("[dbo].[sp_InsertOrder]")
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 60
            };

            result.Parameters.AddWithValue("@SenderEmail", order.SenderEmail);
            result.Parameters.AddWithValue("@SenderName", order.SenderName);
            result.Parameters.AddWithValue("@RecipientEmail", order.RecipientEmail);
            result.Parameters.AddWithValue("@RecipientName", order.RecipientName);
            result.Parameters.AddWithValue("@Voucher", order.Voucher);
            result.Parameters.AddWithValue("@Dedication", order.Dedication);

            return result;
        }

        public SqlCommand CreateGetOrdersCommand()
        {
            var result = new SqlCommand("[dbo].[sp_GetOrders]")
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 60
            };

            return result;
        }

        public SqlCommand CreateGetOrdersBySenderCommand(string senderEmail)
        {
            var result = new SqlCommand("[dbo].[sp_GetOrdersBySender]")
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 60
            };

            result.Parameters.AddWithValue("@SenderEmail", senderEmail);

            return result;
        }
    }
}

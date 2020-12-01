namespace Orders.Services.Order.Data
{
    using System.Data.SqlClient;
    using Entities;

    public interface IOrderSqlCommandFactory
    {
        SqlCommand CreateInsertOrderCommand(OrderEntity order);

        SqlCommand CreateGetOrdersCommand();

        SqlCommand CreateGetOrdersBySenderCommand(string senderEmail);
    }
}

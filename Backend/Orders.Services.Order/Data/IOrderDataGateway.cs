namespace Orders.Services.Order.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;

    public interface IOrderDataGateway
    {
        Task InsertOrderAsync(OrderEntity order);

        Task<IEnumerable<OrderEntity>> GetOrdersAsync();

        Task<IEnumerable<OrderEntity>> GetOrdersBySenderAsync(string senderEmail);
    }
}

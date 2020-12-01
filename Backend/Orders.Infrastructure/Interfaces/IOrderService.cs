namespace Orders.Infrastructure.Interfaces
{
    using System.Threading.Tasks;
    using Messages.Orders.Requests;
    using Messages.Orders.Responses;

    public interface IOrderService
    {
        Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request);

        Task<GetOrdersResponse> GetOrdersAsync();

        Task<GetOrdersResponse> GetOrdersBySenderAsync(string senderEmail);
    }
}

namespace Orders.Api.Extensions.Injection
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Orders.Infrastructure.Interfaces;
    using Orders.Services.Order;
    using Orders.Services.Order.Data;

    public static class OrderServices
    {
        public static void InjectOrderService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IOrderService, OrderService>();
            services.AddSingleton<IOrderSqlCommandFactory, OrderSqlCommandFactory>();
            services.AddSingleton<IOrderDataGateway, OrderSqlDataGateway>();
        }
    }
}

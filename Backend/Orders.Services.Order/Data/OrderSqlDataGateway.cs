namespace Orders.Services.Order.Data
{
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Exceptions;
    using Orders.Infrastructure.Helpers;
    using Orders.Infrastructure.Logging;

    public class OrderSqlDataGateway : IOrderDataGateway
    {
        private readonly ISqlHelper sql;
        private readonly ILogger logger;
        private readonly IOrderSqlCommandFactory factory;

        public OrderSqlDataGateway(
            ISqlHelper helper,
            ILogger logger,
            IOrderSqlCommandFactory factory)
        {
            this.sql = helper;
            this.logger = logger;
            this.factory = factory;
        }

        public async Task InsertOrderAsync(OrderEntity order)
        {
            try
            {
                var command = this.factory.CreateInsertOrderCommand(order);
                await this.sql.ExecuteAsync(command);
            }
            catch (DbException ex)
            {
                this.logger.WriteException(ex);
                throw new OrderDataException(ex);
            }
        }

        public async Task<IEnumerable<OrderEntity>> GetOrdersAsync()
        {
            var result = Enumerable.Empty<OrderEntity>();

            try
            {
                var command = this.factory.CreateGetOrdersCommand();
                result = await this.sql.ReadAsListAsync<OrderEntity>(command);
            }
            catch (DbException ex)
            {
                this.logger.WriteException(ex);
                throw new OrderDataException(ex);
            }

            return result;
        }

        public async Task<IEnumerable<OrderEntity>> GetOrdersBySenderAsync(string senderEmail)
        {
            var result = Enumerable.Empty<OrderEntity>();

            try
            {
                var command = this.factory.CreateGetOrdersBySenderCommand(senderEmail);
                result = await this.sql.ReadAsListAsync<OrderEntity>(command);
            }
            catch (DbException ex)
            {
                this.logger.WriteException(ex);
                throw new OrderDataException(ex);
            }

            return result;
        }
    }
}

namespace Orders.Services.Order
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Orders.Infrastructure.Interfaces;
    using Orders.Infrastructure.Logging;
    using Orders.Infrastructure.Messages.Orders.Requests;
    using Orders.Infrastructure.Messages.Orders.Responses;
    using Orders.Services.Order.Constants;
    using Orders.Services.Order.Data;
    using Orders.Services.Order.Data.Entities;
    using Orders.Services.Order.Exceptions;
    using Orders.Services.Order.Extensions;
    using Orders.Services.Order.Specifications;

    public class OrderService : IOrderService
    {
        private readonly IOrderDataGateway dataGateway;
        private readonly ILogger logger;

        public OrderService(
            IOrderDataGateway dataGateway,
            ILogger logger)
        {
            this.dataGateway = dataGateway;
            this.logger = logger;
        }

        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request)
        {
            var result = new CreateOrderResponse();
            var errors = Enumerable.Empty<string>() as ICollection<string>;

            try
            {
                var spec = new ValidCreateOrderRequestSpecification();
                if (spec.IsSatisfiedBy(request, ref errors))
                {
                    await this.dataGateway.InsertOrderAsync(request.AsEntity());
                }
                else
                {
                    result.SetError(Errors.CreateValidationError, errors);
                }
            }
            catch (Exception ex)
            {
                this.logger.WriteException(ex);
                throw new OrderServiceException(ex);
            }

            return result;
        }

        public async Task<GetOrdersResponse> GetOrdersAsync()
        {
            var result = new GetOrdersResponse();

            try
            {
                result.Data = (await this.dataGateway.GetOrdersAsync()).AsModel();
            }
            catch (Exception ex)
            {
                this.logger.WriteException(ex);
                throw new OrderServiceException(ex);
            }

            return result;
        }

        public async Task<GetOrdersResponse> GetOrdersBySenderAsync(string senderEmail)
        {
            var result = new GetOrdersResponse();

            try
            {
                result.Data = (await this.dataGateway.GetOrdersBySenderAsync(senderEmail)).AsModel();
            }
            catch (Exception ex)
            {
                this.logger.WriteException(ex);
                throw new OrderServiceException(ex);
            }

            return result;
        }
    }
}

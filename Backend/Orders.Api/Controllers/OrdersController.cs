namespace Orders.Api.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Orders.Api.Extensions;
    using Orders.Api.Extensions.Order;
    using Orders.Api.Filters;
    using Orders.Api.Messages.Orders.Requests;
    using Orders.Infrastructure.Interfaces;

    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService service;

        public OrdersController(IOrderService service)
        {
            Debug.Assert(service != null, "Null dependencies");
            this.service = service;
        }

        [HttpGet]
        [AllowAnonymous]
        [ServiceFilter(typeof(ValidateModelStateAttribute))]
        [ServiceFilter(typeof(LogExceptionAttribute))]
        public async Task<IActionResult> GetOrdersAsync()
        {
            var result = await this.service.GetOrdersAsync();
            return this.CreateResponse(result.AsWebResponse());
        }

        [HttpGet("{senderEmail}")]
        [AllowAnonymous]
        [ServiceFilter(typeof(ValidateModelStateAttribute))]
        [ServiceFilter(typeof(LogExceptionAttribute))]
        public async Task<IActionResult> GetOrdersBySenderAsync(string senderEmail)
        {
            var result = await this.service.GetOrdersBySenderAsync(senderEmail);
            return this.CreateResponse(result.AsWebResponse());
        }
    }
}

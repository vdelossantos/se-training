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

    [Route("api/create_order")]
    public class CreateOrderController : ControllerBase
    {
        private readonly IOrderService service;

        public CreateOrderController(IOrderService service)
        {
            Debug.Assert(service != null, "Null dependencies");
            this.service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        [ServiceFilter(typeof(ValidateModelStateAttribute))]
        [ServiceFilter(typeof(LogExceptionAttribute))]
        public async Task<IActionResult> AddOrderAsync([FromBody] AddOrderWebRequest request)
        {
            var result = await this.service.CreateOrderAsync(request.AsRequest());
            return this.CreateResponse(result.AsWebResponse());
        }
    }
}

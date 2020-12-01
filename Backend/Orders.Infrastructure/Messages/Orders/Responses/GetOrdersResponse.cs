namespace Orders.Infrastructure.Messages.Orders.Responses
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Models.Orders;

    public class GetOrdersResponse : Response
    {
        [DataMember]
        public IEnumerable<Order> Data { get; set; }
    }
}

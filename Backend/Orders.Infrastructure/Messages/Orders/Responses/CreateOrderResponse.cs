namespace Orders.Infrastructure.Messages.Orders.Responses
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Text;

    [DataContract]
    public class CreateOrderResponse : Response
    {
        public override Dictionary<string, int> StatusCodeMap => new Dictionary<string, int>
        {
            { string.Empty, (int)HttpStatusCode.Created },
            { "order/create-validation-error", (int)HttpStatusCode.UnprocessableEntity }
        };
    }
}
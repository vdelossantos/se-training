namespace Orders.Services.Order.Specifications
{
    using System.Collections.Generic;
    using Orders.Infrastructure.Messages.Orders.Requests;
    using Orders.Infrastructure.Specifications;

    public class ValidCreateOrderRequestSpecification : Specification<CreateOrderRequest>
    {
        public override bool IsSatisfiedBy(CreateOrderRequest entity, ref ICollection<string> errors)
        {
            var result = true;

            if (string.IsNullOrEmpty(entity.SenderEmail))
            {
                errors.Add("Sender Email is required");
                result = false;
            }

            if (string.IsNullOrEmpty(entity.SenderName))
            {
                errors.Add("Sender Name is required");
                result = false;
            }

            if (string.IsNullOrEmpty(entity.RecipientEmail))
            {
                errors.Add("Recipient Email is required");
                result = false;
            }

            if (string.IsNullOrEmpty(entity.RecipientName))
            {
                errors.Add("Recipient Name is required");
                result = false;
            }

            if (string.IsNullOrEmpty(entity.Voucher))
            {
                errors.Add("Voucher is required");
                result = false;
            }

            // result = errors.Count == 0;
            return result;
        }
    }
}

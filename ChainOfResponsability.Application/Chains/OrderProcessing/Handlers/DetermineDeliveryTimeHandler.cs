using ChainOfResponsability.Domain.Models;

namespace ChainOfResponsability.Application.Chains.OrderProcessing.Handlers
{
    public class DetermineDeliveryTimeHandler : OrderProcessingHandler
    {
        public override Order Handle(Order request)
        {
            if (request.ApplyForDiscount == true)
            {
                return request;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}

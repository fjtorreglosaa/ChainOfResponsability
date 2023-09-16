using ChainOfResponsability.Domain.Models;

namespace ChainOfResponsability.Application.Chains.OrderProcessing.Handlers
{
    public class DetermineFulfillmentTimeHandler : OrderProcessingHandler
    {
        public override Order Handle(Order request)
        {
            if (request.OrderItems.Count() >= 10)
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

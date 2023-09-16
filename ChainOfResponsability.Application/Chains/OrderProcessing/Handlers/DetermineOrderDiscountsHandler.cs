using ChainOfResponsability.Application.Utilities.Constants;
using ChainOfResponsability.Domain.Models;

namespace ChainOfResponsability.Application.Chains.OrderProcessing.Handlers
{
    public class DetermineOrderDiscountsHandler : OrderProcessingHandler
    {
        public override Order Handle(Order request)
        {
            if (request.Type == StringConstants.STANDARD_ORDER && request.OrderItems.Count >= 5)
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

using ChainOfResponsability.Application.Utilities.Constants;
using ChainOfResponsability.Domain.Models;

namespace ChainOfResponsability.Application.Chains.OrderProcessing.Handlers
{
    public class DetermineOrderDiscountsHandler : OrderProcessingHandler
    {
        public override Order Handle(Order request)
        {
            request.StatusID = new Guid("A5494443-EF2F-44CD-ADF8-C8E5C46C3D38");

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

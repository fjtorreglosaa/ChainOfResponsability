using ChainOfResponsability.Application.Utilities.Constants;
using ChainOfResponsability.Domain.Models;

namespace ChainOfResponsability.Application.Chains.OrderProcessing.Handlers
{
    public class DetermineDeliveryTimeHandler : OrderProcessingHandler
    {
        public override Order Handle(Order request)
        {
            request.StatusID = new Guid("BC985511-4E62-4309-8349-F90B942CF9C4");

            if (request.ApplyForDiscount == true)
            {
                request.Type = "OFFERT";
                return request;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}

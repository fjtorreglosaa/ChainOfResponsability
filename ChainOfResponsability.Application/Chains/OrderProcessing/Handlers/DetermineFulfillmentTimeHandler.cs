using ChainOfResponsability.Domain.Models;

namespace ChainOfResponsability.Application.Chains.OrderProcessing.Handlers
{
    public class DetermineFulfillmentTimeHandler : OrderProcessingHandler
    {
        public override Order Handle(Order request)
        {
            request.StatusID = new Guid("B5829769-24F2-42D8-9F5B-45B107C2FC71");

            if (request.OrderItems.Count() <= 10)
            {
                request.Type = "SHORT";
                return request;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}

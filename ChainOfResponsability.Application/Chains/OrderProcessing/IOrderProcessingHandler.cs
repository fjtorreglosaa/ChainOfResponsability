using ChainOfResponsability.Domain.Models;

namespace ChainOfResponsability.Application.Chains.OrderProcessing
{
    public interface IOrderProcessingHandler
    {
        IOrderProcessingHandler SetNext(IOrderProcessingHandler handler);
        Order Handle(Order request);
    }
}

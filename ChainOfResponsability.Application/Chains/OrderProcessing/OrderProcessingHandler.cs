using ChainOfResponsability.Domain.Models;

namespace ChainOfResponsability.Application.Chains.OrderProcessing
{
    public abstract class OrderProcessingHandler : IOrderProcessingHandler
    {
        private IOrderProcessingHandler _nextHandler;

        public IOrderProcessingHandler SetNext(IOrderProcessingHandler handler)
        {
            _nextHandler = handler;

            return handler;
        }

        public virtual Order Handle(Order request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}

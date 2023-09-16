using ChainOfResponsability.Application.Chains.OrderProcessing;
using ChainOfResponsability.Application.DTOs.Order;
using ChainOfResponsability.Domain.Models;

namespace ChainOfResponsability.Application.Services.Contracts
{
    public interface IOrderService
    {
        Task CreateOrder(NewOrderDto data);
        Task ProcessOrder(OrderProcessingHandler handler, Order order);
    }
}

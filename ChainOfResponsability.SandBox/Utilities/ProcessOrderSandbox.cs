using AutoMapper;
using ChainOfResponsability.Application.Chains.OrderProcessing.Handlers;
using ChainOfResponsability.Application.DTOs.Item;
using ChainOfResponsability.Application.DTOs.OrderItem;
using ChainOfResponsability.Application.Services;
using ChainOfResponsability.Domain.Models;
using ChainOfResponsability.Infrastructure.Contexts.Application;
using ChainOfResponsability.Infrastructure.UnitOfWork;

namespace ChainOfResponsability.SandBox.Utilities
{
    public class ProcessOrderSandbox
    {
        public static void Demo()
        {
            var context = new ApplicationDBContext();
            var _unitOfWork = new UnitOfWork(context);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ItemDto, Item>().ReverseMap();
                cfg.CreateMap<OrderItemDto, OrderItem>().ReverseMap();
            });
            var _mapper = new Mapper(config);
            var _orderService = new OrderService(_unitOfWork, _mapper);

            var order = _unitOfWork.Orders.GetAll().FirstOrDefault();

            var step1 = new DetermineDeliveryTimeHandler();
            var step2 = new DetermineOrderDiscountsHandler();
            var step3 = new DetermineFulfillmentTimeHandler();

            step1.SetNext(step2).SetNext(step3);

            _orderService.ProcessOrder(step1, order).Wait();
        }
    }
}

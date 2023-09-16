using AutoMapper;
using ChainOfResponsability.Application.DTOs.Item;
using ChainOfResponsability.Application.DTOs.Order;
using ChainOfResponsability.Application.DTOs.OrderItem;
using ChainOfResponsability.Application.Services;
using ChainOfResponsability.Domain.Models;
using ChainOfResponsability.Infrastructure.Contexts.Application;
using ChainOfResponsability.Infrastructure.UnitOfWork;

namespace ChainOfResponsability.SandBox.Utilities
{
    public class CreateOrderSandbox
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

            var data = new NewOrderDto
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                CreatedBy = Guid.NewGuid(),
                ModifiedBy = Guid.NewGuid(),
                Origen = "Bogota",
                Destination = "Medellin",
                UserId = Guid.NewGuid(),
                ItemsInOrder = new List<OrderItemDto>
                {
                    new OrderItemDto
                    {
                        Id = Guid.NewGuid(),
                        ItemId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Quantity = 9
                    }
                }
            };

            _orderService.CreateOrder(data).Wait();
        }
    }
}

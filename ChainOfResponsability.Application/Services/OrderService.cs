using AutoMapper;
using ChainOfResponsability.Application.Chains.OrderProcessing;
using ChainOfResponsability.Application.DTOs.Order;
using ChainOfResponsability.Application.Services.Contracts;
using ChainOfResponsability.Domain.Models;
using ChainOfResponsability.Infrastructure.UnitOfWork.Contracts;
using System.Text.RegularExpressions;

namespace ChainOfResponsability.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateOrder(NewOrderDto data)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                UserId = data.UserId,
                CustomerReference = GenerateCustomerReference(),
                OrderItems = _mapper.Map<ICollection<OrderItem>>(data.ItemsInOrder)
            };

            foreach (var orderItem in order.OrderItems) orderItem.OrdeId = order.Id;

            await _unitOfWork.Orders.Add(order);
        }

        public async Task ProcessOrder(OrderProcessingHandler handler, Order data)
        {
            var order = await _unitOfWork.Orders.GetByIdAsync(data.Id);

            var result = handler.Handle(order);

            if (result != null)
            {
                await _unitOfWork.CommitAsync();
            }
            else 
            {
                throw new Exception("Unexpected error, please contact support");
            }
        }

        private string GenerateCustomerReference()
        {
            int lastReference = 0;
            
            var orders = _unitOfWork.Orders.GetAll().ToList();

            if (orders.Any()) lastReference = orders.Select(x => int.Parse(Regex.Match(x.CustomerReference, @"\d+").Value)).Max();

            return $"OR-{lastReference + 1:D10}";
        }
    }
}

using ChainOfResponsability.Application.Services.Contracts;
using ChainOfResponsability.Application.Utilities.Constants;
using ChainOfResponsability.Domain.Models;
using ChainOfResponsability.Infrastructure.UnitOfWork.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text.RegularExpressions;

namespace ChainOfResponsability.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateStandardOrder()
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                LastModified = DateTime.Now,
                Type = StringConstants.STANDARD_ORDER,
                StatusID = OrderStatuses.SUBMITTED,
                UserId = Guid.NewGuid(),
                CustomerReference = GenerateCustomerReference(),
                Billed = false,
            };
        }

        private string GenerateCustomerReference()
        {
            var orders = _unitOfWork.Orders.GetAll();

            if (orders.Any())
            {
                var lastReference = orders.Select(x => int.Parse(Regex.Match(x.CustomerReference, @"\d+").Value)).Max();

                return $"OR-{lastReference + 1:D10}";
            }

            return $"OR-0000000001";
        }
    }
}

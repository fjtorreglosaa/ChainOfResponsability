using ChainOfResponsability.Application.DTOs.Item;

namespace ChainOfResponsability.Application.DTOs.OrderItem
{
    public class OrderItemDto
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public decimal Quantity { get; set; }
    }
}

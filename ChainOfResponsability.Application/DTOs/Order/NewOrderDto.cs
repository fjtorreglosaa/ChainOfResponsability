using ChainOfResponsability.Application.DTOs.OrderItem;

namespace ChainOfResponsability.Application.DTOs.Order
{
    public class NewOrderDto
    {
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModified { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public Guid? UserId { get; set; }
        public string? Origen { get; set; }
        public string? Destination { get; set; }
        public List<OrderItemDto> ItemsInOrder { get; set; } = new List<OrderItemDto>();
    }
}

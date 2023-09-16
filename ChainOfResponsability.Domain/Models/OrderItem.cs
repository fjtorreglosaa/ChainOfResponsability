namespace ChainOfResponsability.Domain.Models
{
    public class OrderItem : Entity
    {
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        public Guid OrdeId { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
    }
}

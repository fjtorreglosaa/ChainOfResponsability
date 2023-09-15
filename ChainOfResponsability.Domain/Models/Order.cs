namespace ChainOfResponsability.Domain.Models
{
    public class Order : Entity
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            Invoices = new HashSet<Invoice>();
        }

        public bool? Billed { get; set; }
        public bool? ApplyForDiscount { get; set; }
        public string Type { get; set; }
        public string CustomerReference { get; set; }
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public Guid? DeliveryId { get; set; }
        public Guid StatusID { get; set; }
        public Status Status { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}

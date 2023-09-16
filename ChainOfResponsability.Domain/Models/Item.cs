namespace ChainOfResponsability.Domain.Models
{
    public class Item : Entity
    {
        public Item()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}

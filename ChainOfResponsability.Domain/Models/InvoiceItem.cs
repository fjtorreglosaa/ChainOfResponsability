namespace ChainOfResponsability.Domain.Models
{
    public class InvoiceItem : Entity
    {
        public string CostType { get; set; }
        public decimal Amount { get; set; }
        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}

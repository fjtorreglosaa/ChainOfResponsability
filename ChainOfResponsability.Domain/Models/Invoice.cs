namespace ChainOfResponsability.Domain.Models
{
    public class Invoice : Entity
    {
        public Invoice()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
        }

        public string ReferenceNumber { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }
        public string InvoiceType { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public Guid? StatusId { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}

using ChainOfResponsability.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChainOfResponsability.Infrastructure.EntityConfigurations
{
    internal class InvoiceItemConfigurations : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> builder)
        {
            builder.ToTable("INVOICE_ITEMS");
            builder.HasKey(x => x.Id);
        }
    }
}

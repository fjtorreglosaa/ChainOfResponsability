using ChainOfResponsability.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChainOfResponsability.Infrastructure.EntityConfigurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("STATUSES");
            builder.HasKey(x => x.Id);
        }
    }
}

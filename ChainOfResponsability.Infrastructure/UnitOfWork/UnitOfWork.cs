using ChainOfResponsability.Infrastructure.Contexts.Application;
using ChainOfResponsability.Infrastructure.Repositories;
using ChainOfResponsability.Infrastructure.Repositories.Contracts;
using ChainOfResponsability.Infrastructure.UnitOfWork.Contracts;

namespace ChainOfResponsability.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _dbContext;
        public IInvoiceRepository Invoices { get; private set; }
        public IItemRepository Items { get; private set; }
        public IOrderItemRepository OrderItems { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public IStatusRepository Statuses { get; private set; }
        public IInvoiceItemRepository InvoiceItems { get; private set; }

        public UnitOfWork(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
            Invoices = new InvoiceRepository(dbContext);
            Items = new ItemRepository(dbContext);
            OrderItems = new OrderItemRepository(dbContext);
            Orders = new OrderRepository(dbContext);
            Statuses = new StatusRepository(dbContext);
            InvoiceItems = new InvoiceItemRepository(dbContext);
        }

        public async Task<int> Commit()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}

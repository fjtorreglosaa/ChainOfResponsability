using ChainOfResponsability.Infrastructure.Repositories.Contracts;

namespace ChainOfResponsability.Infrastructure.UnitOfWork.Contracts
{
    public interface IUnitOfWork
    {
        IInvoiceRepository Invoices { get; }
        IItemRepository Items { get; }
        IOrderItemRepository OrderItems { get; }
        IOrderRepository Orders { get; }
        IStatusRepository Statuses { get; }
        IInvoiceItemRepository InvoiceItems { get; }

        Task<int> CommitAsync();
        int Commit();
        void Dispose();
    }
}

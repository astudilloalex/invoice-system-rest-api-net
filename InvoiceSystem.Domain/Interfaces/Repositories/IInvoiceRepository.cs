using InvoiceSystem.CommonCRUD.Interfaces;
using InvoiceSystem.Domain.Entities;

namespace InvoiceSystem.Domain.Interfaces.Repositories;

public interface IInvoiceRepository : INPRepository<Invoice, int>
{
}

using InvoiceSystem.CommonCRUD.Interfaces;
using InvoiceSystem.Domain.Entities;

namespace InvoiceSystem.Domain.Interfaces.Repositories;

public interface IInvoiceDetailRepository : INPRepository<InvoiceDetail, int>
{
}

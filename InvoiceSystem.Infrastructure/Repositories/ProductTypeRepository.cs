using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class ProductTypeRepository : NPRepository<ProductType, short>, IProductTypeRepository
{
    public ProductTypeRepository(PostgreSQLContext context) : base(context)
    {
    }
}

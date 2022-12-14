using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class ProductCategoryRepository : NPRepository<ProductCategory, short>, IProductCategoryRepository
{
    public ProductCategoryRepository(PostgreSQLContext context) : base(context)
    {
    }
}

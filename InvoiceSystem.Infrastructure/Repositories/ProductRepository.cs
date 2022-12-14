using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class ProductRepository : NPRepository<Product, int>, IProductRepository
{
    public ProductRepository(PostgreSQLContext context) : base(context)
    {
    }
}

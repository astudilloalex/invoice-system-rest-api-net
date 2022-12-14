using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class CityRepository : NPRepository<City, int>, ICityRepository
{
    public CityRepository(PostgreSQLContext context) : base(context)
    {
    }
}

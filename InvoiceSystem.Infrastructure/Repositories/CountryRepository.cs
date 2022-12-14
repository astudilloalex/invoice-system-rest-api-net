using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class CountryRepository : NPRepository<Country, short>, ICountryRepository
{
    public CountryRepository(PostgreSQLContext context) : base(context)
    {
    }
}

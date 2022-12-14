using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class CompanyRepository : NPRepository<Company, int>, ICompanyRepository
{
    public CompanyRepository(PostgreSQLContext context) : base(context)
    {
    }
}

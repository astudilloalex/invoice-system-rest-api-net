using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class PersonDocumentTypeRepository : NPRepository<PersonDocumentType, short>, IPersonDocumentTypeRepository
{
    public PersonDocumentTypeRepository(PostgreSQLContext context) : base(context)
    {
    }
}

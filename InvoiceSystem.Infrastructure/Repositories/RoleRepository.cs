using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class RoleRepository : NPRepository<Role, short>, IRoleRepository
{
    public RoleRepository(PostgreSQLContext context) : base(context)
    {
    }
}

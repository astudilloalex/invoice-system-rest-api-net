using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class UserRepository : NPRepository<User, int>, IUserRepository
{
    public UserRepository(PostgreSQLContext context) : base(context)
    {
    }
}

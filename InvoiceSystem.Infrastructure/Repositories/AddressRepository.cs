using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class AddressRepository : NPRepository<Address, int>, IAddressRepository
{
    public AddressRepository(PostgreSQLContext context) : base(context)
    {
    }
}

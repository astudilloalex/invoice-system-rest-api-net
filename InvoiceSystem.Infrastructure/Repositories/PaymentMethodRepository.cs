using InvoiceSystem.Domain.Entities;
using InvoiceSystem.Domain.Interfaces.Repositories;
using InvoiceSystem.Infrastructure.Connections;

namespace InvoiceSystem.Infrastructure.Repositories;

public class PaymentMethodRepository : NPRepository<PaymentMethod, short>, IPaymentMethodRepository
{
    public PaymentMethodRepository(PostgreSQLContext context) : base(context)
    {
    }
}

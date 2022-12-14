using InvoiceSystem.Domain.Entities;

namespace InvoiceSystem.Domain.Interfaces.Services;

public interface IPaymentMethodService : INPService<PaymentMethod, short>
{
}

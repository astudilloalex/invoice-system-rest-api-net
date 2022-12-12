using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceSystem.API.Controllers.V1;

[Route("api/v1/payment-method")]
[ApiController]
[Authorize]
public class PaymentMethodController : ControllerBase
{
}

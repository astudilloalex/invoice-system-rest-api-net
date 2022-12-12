using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceSystem.API.Controllers.V1;

[Route("api/v1/dial-in-code")]
[ApiController]
[Authorize]
public class DialInCodeController : ControllerBase
{
}

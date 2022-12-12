using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceSystem.API.Controllers.V1;

[Route("api/v1/country")]
[ApiController]
[Authorize]
public class CountryController : ControllerBase
{
}

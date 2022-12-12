using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceSystem.API.Controllers.V1;

[Route("api/v1/product")]
[ApiController]
[Authorize]
public class ProductController : ControllerBase
{
}

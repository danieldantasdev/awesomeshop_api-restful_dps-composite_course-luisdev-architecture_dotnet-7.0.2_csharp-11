using Composite.Application.Configurations;
using Composite.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Composite.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    [HttpPost]
    public IActionResult Post(
        OrderInputModel model
    )
    {
        return Ok(BusinessHours.GetInstance());
    }
}
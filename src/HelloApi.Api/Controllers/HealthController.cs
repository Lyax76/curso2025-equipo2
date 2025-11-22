using HelloApi.Application;
using HelloApi.Domain;
using Microsoft.AspNetCore.Mvc;

namespace HelloApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    private readonly IHealthService _healthService;

    public HealthController(IHealthService healthService)
    {
        _healthService = healthService;
    }

    [HttpGet]
    public ActionResult<HealthDto> Get()
    {
        var result = _healthService.GetHealth();
        return Ok(result);
    }
}

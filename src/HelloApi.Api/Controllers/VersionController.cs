using HelloApi.Application;
using HelloApi.Domain;
using Microsoft.AspNetCore.Mvc;

namespace HelloApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VersionController : ControllerBase
{
    private readonly IVersionService _versionService;

    public VersionController(IVersionService versionService)
    {
        _versionService = versionService;
    }

    [HttpGet]
    public ActionResult<VersionDto> Get()
    {
        var result = _versionService.GetVersion();
        return Ok(result);
    }
}

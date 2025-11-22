using HelloApi.Application;
using HelloApi.Domain;
using Microsoft.Extensions.Hosting;

namespace HelloApi.Infrastructure;

public sealed class VersionService : IVersionService
{
    private readonly IHostEnvironment _env;

    public VersionService(IHostEnvironment env)
    {
        _env = env;
    }

    public VersionDto GetVersion()
    {
        var version = typeof(VersionService)
            .Assembly
            .GetName()
            .Version?
            .ToString() ?? "1.0.0";

        return new VersionDto(
            Version: version,
            Environment: _env.EnvironmentName
        );
    }
}

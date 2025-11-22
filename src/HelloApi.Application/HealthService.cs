using HelloApi.Application;
using HelloApi.Domain;

namespace HelloApi.Infrastructure;

public sealed class HealthService : IHealthService
{
    public HealthDto GetHealth()
    {
        return new HealthDto(
            Status: "OK",
            CheckedAtUtc: DateTime.UtcNow
        );
    }
}

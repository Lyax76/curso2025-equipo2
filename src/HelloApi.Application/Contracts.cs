using HelloApi.Domain;

namespace HelloApi.Application;

public interface IHealthService
{
    HealthDto GetHealth();
}

public interface IVersionService
{
    VersionDto GetVersion();
}

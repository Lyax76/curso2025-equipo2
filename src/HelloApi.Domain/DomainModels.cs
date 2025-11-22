namespace HelloApi.Domain;

public record HealthDto(string Status, DateTime CheckedAtUtc);

public record VersionDto(string Version, string Environment);

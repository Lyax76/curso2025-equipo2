using HelloApi.Infrastructure;
using HelloApi.Domain;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.FileProviders;
using Xunit;

namespace HelloApi.Tests;

public class VersionServiceTests
{
    private sealed class FakeHostEnvironment : IHostEnvironment
    {
        public string EnvironmentName { get; set; } = "Testing";
        public string ApplicationName { get; set; } = "HelloApi.Tests";
        public string ContentRootPath { get; set; } = Directory.GetCurrentDirectory();

        // En .NET 9 ya no es obligatorio tener un proveedor físico
        public IFileProvider ContentRootFileProvider { get; set; } = null!;
    }

    [Fact]
    public void GetVersion_ShouldReturnEnvironmentFromHost()
    {
        var fakeEnv = new FakeHostEnvironment
        {
            EnvironmentName = "Testing"
        };

        var service = new VersionService(fakeEnv);

        var dto = service.GetVersion();

        Assert.Equal("Testing", dto.Environment);
        Assert.False(string.IsNullOrWhiteSpace(dto.Version));
    }
}


using Xunit;

namespace Novolis.Install.Tests;

public class DoctorCommandTests
{
    [Fact]
    public async Task Doctor_returns_success()
    {
        var exit = await Program.RunAsync(["doctor"]);
        Assert.Equal(0, exit);
    }
}

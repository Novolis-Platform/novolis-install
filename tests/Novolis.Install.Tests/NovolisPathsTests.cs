using Novolis.Install.Paths;
using Xunit;

namespace Novolis.Install.Tests;

public class NovolisPathsTests
{
    [Fact]
    public void DataRoot_is_under_user_profile()
    {
        Assert.Contains("Novolis", NovolisPaths.DataRoot, StringComparison.OrdinalIgnoreCase);
        Assert.DoesNotContain("..", NovolisPaths.DataRoot);
    }
}

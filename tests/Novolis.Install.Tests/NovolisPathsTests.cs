using Novolis.Install.Paths;
using TUnit.Core;

namespace Novolis.Install.Tests;

public class NovolisPathsTests
{
    [Test]
    public async Task DataRoot_is_under_user_profile()
    {
        await Assert.That(NovolisPaths.DataRoot).Contains("Novolis", StringComparison.OrdinalIgnoreCase);
        await Assert.That(NovolisPaths.DataRoot).DoesNotContain("..");
    }
}

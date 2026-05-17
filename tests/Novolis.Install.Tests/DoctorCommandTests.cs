using TUnit.Core;

namespace Novolis.Install.Tests;

public class DoctorCommandTests
{
    [Test]
    public async Task Doctor_returns_success()
    {
        var exit = await Program.RunAsync(["doctor"]);
        await Assert.That(exit).IsEqualTo(0);
    }
}

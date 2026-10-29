using Soenneker.Tests.HostedUnit;

namespace Soenneker.Incident.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class IncidentOpenApiClientTests : HostedUnitTest
{
    public IncidentOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

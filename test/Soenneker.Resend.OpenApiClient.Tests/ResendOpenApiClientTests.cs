using Soenneker.Tests.HostedUnit;

namespace Soenneker.Resend.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ResendOpenApiClientTests : HostedUnitTest
{


    public ResendOpenApiClientTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}

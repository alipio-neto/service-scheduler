using Xunit;

namespace atlas.api.service_scheduler.tests.IntegrationTests
{
    [CollectionDefinition( "SharedTest" )]
	public class SharedTestContext
		: ICollectionFixture<TestContext>
	{
	}
}
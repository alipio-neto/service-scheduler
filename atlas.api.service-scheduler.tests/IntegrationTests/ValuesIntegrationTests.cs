using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using atlas.test;

namespace atlas.api.service_scheduler.tests.IntegrationTests
{
    [Collection("SharedTest")]
    [Trait("Integration", "Values")]
    public class ValuesIntegrationTests : BaseIntegrationTests
    {
        private readonly TestContext m_Context;
        public ValuesIntegrationTests ( TestContext p_Context )
        { 
            m_Context = p_Context;
        }

        [Fact(DisplayName = "IntegrationExample")]
        public async Task IntegrationExample()
        {
            "1".Should().Be("1");
        }
    }
}

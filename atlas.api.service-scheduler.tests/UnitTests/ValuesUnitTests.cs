using atlas.api.service_scheduler.Controllers;
using atlas.web;
using atlas.web.User;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace atlas.api.service_scheduler.tests.UnitTests
{
    [Trait("Unit", "Values")]
    public class ValuesUnitTests
    {
        [Fact(DisplayName = "UnitExample")]
        public async Task UnitExample()
        {
            "1".Should().Be("1");
        }
    }
}
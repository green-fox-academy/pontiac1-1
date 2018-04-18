using groot.Controllers;
using groot.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1.Controllers
{
    class testcontrol : IDisposable
    {
        GrootContext context;

        public testcontrol()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<GrootContext>()
                .UseInMemoryDatabase()
                .UseInternalServiceProvider(serviceProvider);

            context = new GrootContext(builder.Options);
        }

        [Fact]
        public async Task WhoAreYou()
        {
            var controller = new GuardianController();

            var result = await controller.Groot();
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

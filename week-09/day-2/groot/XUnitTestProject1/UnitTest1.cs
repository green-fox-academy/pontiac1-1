using groot;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private HttpClient Client;
        private TestServer Server;

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }


    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Text;

using Mongo2Go;
using MongoDB.Bson;
using MongoDB.Driver;


namespace atlas.api.service_scheduler.tests.IntegrationTests
{
	public class TestContext : IDisposable
	{
		public TestServer Server;
		
		public MongoDbRunner LocalDatabase;
		

		public TestContext()
		{
			
			LocalDatabase = MongoDbRunner.Start();
			
			
			var builder = new WebHostBuilder()
				.UseEnvironment( TestConfig.ENVIRONMENT )
				
				.UseSetting( TestConfig.CONNECTIONSTRING, LocalDatabase.ConnectionString )
				
				.UseStartup<Startup>();

			Server = new TestServer( builder );
		}

		public void Dispose()
		{
			
			LocalDatabase?.Dispose();
			
			Server?.Dispose();
		}
	}
}

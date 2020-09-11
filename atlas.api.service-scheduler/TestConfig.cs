using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atlas.api.service_scheduler
{
    public class TestConfig
    {
		public const string ENVIRONMENT = "TESTING";

		public const string CONNECTIONSTRING = "dbConnectionString";
		public const string DATABASENAME = "integrationTest";
		
		public static bool IsEnabled( IWebHostEnvironment env )
		{
			return env.IsEnvironment( ENVIRONMENT );
		}


		public static mongo.AtlasMongoConfig GetDatabase(IConfiguration cfg)
		{
			var dbConfig = new mongo.AtlasMongoConfig(cfg[CONNECTIONSTRING]);
			dbConfig.DbName = DATABASENAME;
			return dbConfig;
		}

	}
}

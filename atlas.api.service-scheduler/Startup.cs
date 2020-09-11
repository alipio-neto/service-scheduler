using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using atlas.web.api;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;
using atlas.api.service_scheduler.DB;


namespace atlas.api.service_scheduler
{
	[ExcludeFromCodeCoverage]
	public class Startup : AtlasApiStartup
	{
		private bool IsTest { get => TestConfig.IsEnabled( Environment ); }

		
		private mongo.AtlasMongoConfig MongoConfig => GetDatabaseConfig( AtlasBuilder.Store );
		

		public Startup( IConfiguration configuration, IWebHostEnvironment env )
            : base( configuration, env )
		{
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices( IServiceCollection services )
		{
			BaseConfigureServices( services );


			services.AddAtlasMongoDatabase<Database>( () => MongoConfig );



		}


		protected override void ConfigureHealthChecks(IHealthChecksBuilder p_Builder)
        {
            p_Builder.AddAtlasReadyHealthCheck(
                (b, t) => b.AddMongoDb( MongoConfig.GetConnectionString(), tags: t )
            );
        }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

		public void Configure( IApplicationBuilder app, IWebHostEnvironment env, Database p_Database )

		{
            BaseConfigure( app, env );
		}
		

		#region FUNCOES AUXILIARES
		private mongo.AtlasMongoConfig GetDatabaseConfig( IAtlasConfigStore p_Store )
		{
			if( IsTest )
			{
				return TestConfig.GetDatabase( Configuration );
			}
			return p_Store.GetAppConfigAs<mongo.AtlasMongoConfig>( "mongodb" );
		}
        #endregion


#if DEBUG
        protected override void RegisterCustomApi( IAtlasCustomUri p_CustomUri )
        {
            p_CustomUri.SetApiDefaultHost( "http://atlas.devel/dev" );
        }
#endif

	}
}

using atlas.api.service_scheduler.DB.Entities;
using MongoDB.Driver;
using atlas.api.service_scheduler.DB.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace atlas.api.service_scheduler.DB.Repositories
{
    public class ExampleRepository : mongo.AtlasMongoRepository<ExampleEntity>, IExampleRepository
    {

        public ExampleRepository ( IMongoDatabase p_Database )
       : base(p_Database, "Example")
        {
        }

        public async Task<IEnumerable<ExampleEntity>> FindAllAsync(){
            throw new NotImplementedException();
        }
    }
}
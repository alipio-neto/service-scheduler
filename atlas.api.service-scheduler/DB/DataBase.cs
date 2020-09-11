using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atlas.api.service_scheduler.DB.Entities;
using atlas.api.service_scheduler.DB.Repositories;
using atlas.api.service_scheduler.DB.Repositories.Interfaces;

namespace atlas.api.service_scheduler.DB
{
    public class Database : mongo.AtlasMongoDatabase
	{
        public ExampleRepository Examples { 
            get => Get<ExampleRepository, ExampleEntity>();
        }
    }
}
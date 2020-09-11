using atlas.api.service_scheduler.DB.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace atlas.api.service_scheduler.DB.Repositories.Interfaces
{
    public interface IExampleRepository
    {
        Task<IEnumerable<ExampleEntity>> FindAllAsync();
    }
}
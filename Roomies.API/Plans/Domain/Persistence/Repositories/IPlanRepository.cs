using Roomies.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roomies.API.Domain.Repositories
{
    public interface IPlanRepository
    {
        Task<IEnumerable<Domain.Models.Plan>> ListAsync();
        Task AddAsync(Domain.Models.Plan plan);
        Task<Models.Plan> FindById(int id);
        void Update(Models.Plan plan);
        void Remove(Models.Plan plan);
    }
}

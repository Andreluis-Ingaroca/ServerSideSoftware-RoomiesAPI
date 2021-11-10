﻿using Roomies.API.Domain.Models;
using Roomies.API.Domain.Services.Communications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roomies.API.Domain.Services
{
    public interface IPlanService
    {
        Task<IEnumerable<Models.Plan>> ListAsync();
        Task<PlanResponse> GetByIdAsync(int id);
        Task<PlanResponse> SaveAsync(Models.Plan plan);
        Task<PlanResponse> UpdateAsync(int id, Models.Plan plan);
        Task<PlanResponse> DeleteAsync(int id);
    }
}

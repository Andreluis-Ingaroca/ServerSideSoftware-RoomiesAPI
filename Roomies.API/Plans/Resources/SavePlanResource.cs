using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roomies.API.Plan.Resources
{
    public class SavePlanResource
    {
        public float Price { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
    }
}

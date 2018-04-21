using STU.Common.Result;
using STU.Shared.Model;
using STU.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Services
{
    public class LocationService : BaseService<Location>, ILocationService
    {
        public LocationService(IRepository<Location> locationRepository) : base(locationRepository) { }

        public Result<Location> GetDirections(string buildingId)
        {
            return new Result<Location> { Success = true, Data = Repository.All(loc => loc.LocationId == buildingId).FirstOrDefault() };
        }
    }
}

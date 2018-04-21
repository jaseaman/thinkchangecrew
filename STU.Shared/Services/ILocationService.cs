using STU.Common.Result;
using STU.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Services
{
    public interface ILocationService
    {
        Result<Location> GetDirections(string buildingId);
    }
}

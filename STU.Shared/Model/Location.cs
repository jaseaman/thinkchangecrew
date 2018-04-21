using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Model
{
    public class Location : BaseModel
    {
        public string Name { get; set; }
        public int BuildingID { get; set; }
        public string LocationID { get; set; }

        public string LocationLink { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public string UTSOwned { get; set; }
    }
}

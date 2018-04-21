using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Model
{
    public class Event : BaseModel
    {
        public string Name { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}

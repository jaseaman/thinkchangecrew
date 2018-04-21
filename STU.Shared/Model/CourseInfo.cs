using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Model
{
    public class CourseInfo : BaseModel
    {
        public string CourseID { get; set; }
        public string Course { get; set; }
        public string Brief { get; set; }
        public float RequiredATAR { get; set; }
    }
}

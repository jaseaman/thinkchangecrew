using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Model
{
    public class Course : BaseModel
    {
        public string CourseID { get; set; }
        public string CourseTitle { get; set; }
        public string Brief { get; set; }
        public double RequiredATAR { get; set; }

        public string CourseLink { get; set; }
    }
}

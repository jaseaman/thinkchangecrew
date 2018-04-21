using STU.Shared.Model;
using STU.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Services
{
    public class CourseInfoService : BaseService<CourseInfo>, ICourseInfoService
    {
        public CourseInfoService(IRepository<CourseInfo> courseRepository) : base(courseRepository) { }
    }
}

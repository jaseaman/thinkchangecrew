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
    public class CourseInfoService : BaseService<Course>, ICourseInfoService
    {
        public CourseInfoService(IRepository<Course> courseRepository) : base(courseRepository) { }

        public Result<Course> RetrieveCourseInfo(string courseId)
        {
            return new Result<Course> { Success = true, Data = Repository.All(c => c.CourseID == courseId).FirstOrDefault() };
        }
    }
}

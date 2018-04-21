using STU.Shared.Model;
using STU.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Services
{
    public abstract class BaseService<T> where T : BaseModel
    {
        public BaseService(IRepository<T> repository)
        {
            Repository = repository;
        }

        public IRepository<T> Repository { get; set; }
    }
}

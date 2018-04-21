using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Model
{
    public class QueryResult
    {
        public List<Intent> Intents { get; set; }
        public List<Entity> Entities { get; set; }
    }
}

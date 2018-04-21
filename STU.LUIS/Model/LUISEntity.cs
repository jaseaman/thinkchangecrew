using STU.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.LUIS.Model
{
    public class LUISEntity
    {
        public string Entity { get; set; }
        public string Type { get; set; }

        public int StartIndex { get; set; }
        public int EndIndex { get; set; }

        public List<string> Values { get; set; }

        public Entity ToEntity()
        {
            return new Entity { Name = Entity, Type = Type };
        }
    }
}

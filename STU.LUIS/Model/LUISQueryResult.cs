using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.LUIS.Model
{
    public class LUISQueryResult
    {
        public List<LUISIntent> Intents { get; set; }

        public List<LUISEntity> Entities { get; set; }

    }
}

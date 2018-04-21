using STU.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.LUIS.Model
{
    public class LUISIntent
    {
        public string Intent { get; set; }
        public double Score { get; set; }

        public Intent ToIntent()
        {
            return new Intent { Score = Score, Name = Intent };
        }
    }
}

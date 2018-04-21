using STU.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STU.Bot.Model
{
    public class STUResponse : BaseModel
    {
        public string IntentType { get; set; }
        public List<string> Responses { get; set; }
    }
}
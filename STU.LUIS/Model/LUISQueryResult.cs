using Newtonsoft.Json;
using STU.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.LUIS.Model
{
    public class LUISQueryResult
    {
        public string Query { get; set; }

        public LUISIntent TopScoringIntent { get; set; }

        [JsonProperty(PropertyName = "intents")]
        public List<LUISIntent> Intents { get; set; }

        public List<LUISEntity> Entities { get; set; }

        public QueryResult ToQueryResult()
        {
            return new QueryResult { Entities = Entities.Select(qr => qr.ToEntity()).ToList(), Intents = Intents.Select(i => i.ToIntent()).ToList() };
        }
    }
}

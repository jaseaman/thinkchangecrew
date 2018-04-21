using STU.Common.Result;
using STU.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.LUIS
{
    public interface ILanguageProccessingService
    {
        Result<QueryResult> ProcessQuery(string query);
    }
}

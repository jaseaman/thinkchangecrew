using STU.Bot.Model;
using STU.Common.Result;
using STU.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Services
{
    public class ResponseService : BaseService<STUResponse>, IResponseService
    {
        static Random randomGenerator = new Random();

        public ResponseService(IRepository<STUResponse> repository) : base(repository) { }

        public Result<string> GetRandomResponse(string intentType, string[] injectStrings = null)
        {
            STUResponse response = Repository.All(r => r.IntentType.Equals(intentType)).FirstOrDefault();

            int index = randomGenerator.Next(response.Responses.Count);

            return new Result<string> { Success = true, Data = String.Format(response.Responses[index], injectStrings) };
        }
    }
}

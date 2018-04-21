using STU.Bot.Model;
using STU.Common.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Services
{
    public interface IResponseService
    {
        Result<string> GetRandomResponse(string intentType, string[] injectStrings = null);
    }
}

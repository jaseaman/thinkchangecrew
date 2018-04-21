using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using RestSharp;
using STU.Common.Result;
using STU.Shared.Model;

namespace STU.LUIS
{
    public class LUISService : ILanguageProccessingService
    {

        public async Task<Result<QueryResult>> ProcessQueryAsync(string query)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // This app ID is for a public sample app that recognizes requests to turn on and turn off lights
            var luisAppId = "d624c683-438c-4f02-81f8-230187f3861a";
            var subscriptionKey = "bdb0503feebf43a68bfc860d6b80b9d0";

            // The request header contains your subscription key
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

            // The "q" parameter contains the utterance to send to LUIS
            queryString["q"] = query;

            var uri = "https://westus.api.cognitive.microsoft.com/luis/v2.0/apps/" + luisAppId + "?" + queryString;
            var response = await client.GetAsync(uri);

            var strResponseContent = await response.Content.ReadAsStringAsync();

            return new Result<QueryResult> { };
        }
    }
}

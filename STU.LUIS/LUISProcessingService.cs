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
using STU.LUIS.Model;
using STU.Shared.Model;

namespace STU.LUIS
{
    public class LUISProcessingService : ILanguageProcessingService
    {
        public static string LUISEndpoint = "https://australiaeast.api.cognitive.microsoft.com";
        public static string ApiPath = "/luis/v2.0/apps/";
        public static string LuisAppId = "cbb68bc7-90d7-4ba6-ac4b-1f4cf52ade98";
        public static string BingAutocorrectKey = "eb3dc69c0370441a9533f9c708812d78";


        public async Task<Result<QueryResult>> ProcessQueryAsync(string query)
        {
            RestClient client = new RestClient(LUISEndpoint);
            RestRequest request = new RestRequest(ApiPath + LuisAppId, Method.GET);

            string subscriptionKey = "db29cb1cb95d42368132ecedf59111a3";

            request.AddQueryParameter("subscription-key", subscriptionKey);
            request.AddQueryParameter("q", query);
            request.AddQueryParameter("spellCheck", "true");
            request.AddQueryParameter("bing-spell-check-subscription-key", BingAutocorrectKey);

            IRestResponse<LUISQueryResult> result = client.Execute<LUISQueryResult>(request);

            return new Result<QueryResult> { Success = true, Data = result.Data.ToQueryResult() };
        }
    }
}

using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using MongoDB.Driver;
using STU.Bot.Model;
using STU.Bot.Repository;
using STU.Shared.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace STU.Bot.Dialogs
{
    [Serializable]
    public class LUISResponseDialog : LuisDialog<object>
    {
        //Need to abstract this out of the Dialog
        protected static string MongoString = "mongodb://utsstu:dKgwyxIXeCT3rB3igdrgqIFDFm75FqOfua8NhhxSopj8oWEhUIjFn4cPhOCljdFC6RfN8zjTkOrBhItBGHTqrQ==@utsstu.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
        protected static IResponseService _responseService = new ResponseService(new MongoDbRepository<STUResponse>(new MongoClient(MongoString), "STU"));

        //public Task StartAsync(IDialogContext context)
        //{
        //    context.Wait(UserQueryRecievedAsync);

        //    return Task.CompletedTask;
        //}

        public LUISResponseDialog() : base(new LuisService(new LuisModelAttribute(
        ConfigurationManager.AppSettings["LuisAppId"],
        ConfigurationManager.AppSettings["LuisAPIKey"],
        domain: ConfigurationManager.AppSettings["LuisAPIHostName"])))
        { }

        [LuisIntent("HowIsSTU")]
        [LuisIntent("Help")]
        [LuisIntent("IntroduceStu")]
        public async Task StringResponse(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            _responseService.GetRandomResponse(result.TopScoringIntent.Intent);
        }

        [LuisIntent("Location")]
        public async Task ProvideLocation(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {

        }

        [LuisIntent("")]
        [LuisIntent("None")]
        public async Task ProvideApologies(IDialogContext context, LuisResult result)
        {
            _responseService.GetRandomResponse(result.TopScoringIntent.Intent);
        }

        public async Task UserQueryRecievedAsync(IDialogContext context, IAwaitable<object> result)
        {
            Activity activty = await result as Activity;

            //ILanguageProcessingService 

            await context.PostAsync("Hello world");
        }
    }
}
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace STU.Bot.Dialogs
{
    [Serializable]
    public class LUISResponseDialog : LuisDialog<object>
    {


        public Task StartAsync(IDialogContext context)
        {
            context.Wait(UserQueryRecievedAsync);

            return Task.CompletedTask;
        }

        [LuisIntent("HowIsSTU")]
        public async Task HowIsSTU(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {

        }

        [LuisIntent("Help")]
        public async Task Help(IDialogContext context, LuisResult result)
        {
        }


        [LuisIntent("IntroduceStu")]
        public async Task IntroduceSTU(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {

        }

        [LuisIntent("Location")]
        public async Task ProvideLocation(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {

        }

        [LuisIntent("None")]
        public async Task ProvideApologies(IDialogContext context, LuisResult result)
        {

        }

        public async Task UserQueryRecievedAsync(IDialogContext context, IAwaitable<object> result)
        {
            Activity activty = await result as Activity;

            //ILanguageProcessingService 

            await context.PostAsync("Hello world");
        }
    }
}
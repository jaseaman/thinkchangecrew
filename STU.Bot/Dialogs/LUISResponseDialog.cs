using Microsoft.Bot.Builder.Dialogs;
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

        public async Task UserQueryRecievedAsync(IDialogContext context, IAwaitable<object> result)
        {
            Activity activty = await result as Activity;

            //ILanguageProcessingService 

            await context.PostAsync("Hello world");

            context.Wait(UserQueryRecievedAsync);
        }
    }
}
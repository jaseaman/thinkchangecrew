using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace STU.Bot.Dialogs
{
    [Serializable]
    public class UserInputDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            throw new NotImplementedException();
        }

        public async Task UserQueryRecievedAsync(IDialogContext context, IAwaitable<object> result)
        {
            //ILanguageProcessingService 
        }
    }
}
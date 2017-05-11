using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DLCBot.Dialogs
{
    [LuisModel("2ce20569-f378-4bea-93b2-651758dd3b26", "8af465818c3b400c9ea945a449fad81b")]

    [Serializable]
    public class DLCDialog : LuisDialog<object>
    {
        [LuisIntent("LightSwitch")]
        public async Task ShowDevice(IDialogContext context, LuisResult result)
        {
             
        }

    }
}
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
        private Boolean deviceOn = false;

        [LuisIntent("TurnDeviceOn")]
        public async Task TurnDeviceOn(IDialogContext context, LuisResult result)
        {
            if (deviceOn)
            {
                await context.PostAsync("The device is already on!");
            }
            else
            {
                await context.PostAsync("The device has been turned on!");
                deviceOn = true;
            }
            context.Wait(MessageReceived); 
        }

        [LuisIntent("TurnDeviceOff")]
        public async Task TurnDeviceOff(IDialogContext context, LuisResult result)
        {
            if (!deviceOn)
            {
                await context.PostAsync("The device is already off!");
            }
            else
            {
                await context.PostAsync("The device has been turned off!");
                deviceOn = false;
            }
            context.Wait(MessageReceived);
        }

        [LuisIntent("ChangeCycle")]
        public async Task ChangeCycle(IDialogContext context, LuisResult result)
        {
            //Change the cycle
            context.Wait(MessageReceived);
        }
    }
}
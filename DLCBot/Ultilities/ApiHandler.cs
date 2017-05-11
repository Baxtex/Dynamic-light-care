using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DLCBot.Ultilities
{
    public static class ApiHandler
    {
        private const string baseUrl = "http://dynamiclight.azurewebsites.net/api/1/";
        private static readonly RestClient client;

        static ApiHandler()
        {
            client = new RestClient();
            client.BaseUrl = new Uri(baseUrl);
        }

        //Posts new conversations.
        internal static void TurnLightsOn()
        {
            var request = new RestRequest("LightsOn", Method.POST);
            var response = client.Execute(request);
        }


    }
}
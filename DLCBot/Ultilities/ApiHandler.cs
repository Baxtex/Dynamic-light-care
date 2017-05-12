using RestSharp;
using System;

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

        //Turn light on or off.
        internal static void PostTurnLights(string action)
        {
            var request = new RestRequest("lightsOn", Method.POST);
            request.AddQueryParameter("action", action);
            var response = client.Execute(request);
        }

        //Change the ligt. 
        internal static void PostChangeLight(string action)
        {
            var request = new RestRequest("lightsOn", Method.POST);
            request.AddQueryParameter("action", action);
            var response = client.Execute(request);
        }
    }
}
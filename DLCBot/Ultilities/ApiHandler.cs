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

        internal static void GetTurnLightsOff()
        {
            var request = new RestRequest("lightStatus", Method.GET);
            var response = client.Execute(request);
        }

        internal static void PostTurnLightsOn()
        {
            var request = new RestRequest("lightsOn", Method.POST);
            var response = client.Execute(request);
        }

        internal static void PostTurnLightsOff()
        {
            var request = new RestRequest("lightsOff", Method.POST);
            var response = client.Execute(request);
        }
    }
}
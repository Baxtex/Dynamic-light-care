using RestSharp;
using System;

namespace DLCBot.Ultilities
{
    public static class ApiHandler
    {
        private static readonly RestClient client;

        static ApiHandler()
        {
            client = new RestClient();
        }

        //Turn light on or off.
        internal static void PostTurnLights(string action)
        {
            var request = new RestRequest("172.20.10.11:8081/turnondevice", Method.POST);
            var response = client.Execute(request);
        }

        //Change the ligt. 
        internal static void PostChangeLight(string action)
        {
            var request = new RestRequest("172.20.10.11:8081/turnoffdevice", Method.POST);
            var response = client.Execute(request);
        }
    }
}
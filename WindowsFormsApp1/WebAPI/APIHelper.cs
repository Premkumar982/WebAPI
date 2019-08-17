using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebAPI
{
    public static class APIHelper
    {
        public static HttpClient httpClient { get; set; }

        public static void InitialiseClient()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
        }
    }
}

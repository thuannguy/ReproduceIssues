using System;
using System.Net.Http;

namespace Model
{
    public class Dummy2
    {
        public static void DoNothing()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://github.com");
        }
    }
}
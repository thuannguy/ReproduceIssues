using System;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WebStuff
{
    public static class DummyClass
    {
        public static void DoNothing()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://github.com");
        }
    }
}

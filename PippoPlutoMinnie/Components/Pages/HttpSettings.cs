namespace PippoPlutoMinnie.Components.Pages
{
    public static class HttpSettings
    {
        public static HttpClient siteUri = new()
        {
            BaseAddress = new Uri("http://192.168.149.209:3001/")

        };
        public static string clientPath = "client";
    }
}

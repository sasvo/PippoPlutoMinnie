namespace PippoPlutoMinnie.Components.Pages
{
    public static class HttpSettings
    {
        public static HttpClient siteUri = new()
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com/"),

        };
        public static string tempPath = "todos/3";
        public static string enginesPath = "todos/3";
        public static string cameraPath = "todos/3";
        public static string batteryPath = "todos/3";
        public static string mapPath = "todos/3";
        public static string logPath = "todos/3";
        public static string gyroPath = "todos/3";
    }
}

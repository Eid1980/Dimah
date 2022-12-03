namespace Dimah.API.Configurations
{
    public static class HttpResponseExtensions
    {
        public static void AddApplicationErrorHeader(this HttpResponse response, string message)
        {
            try
            {
                response.Headers.Add("Application-Error", message);
                response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
                response.Headers.Add("Access-Control-Allow-origin", "*");
            }
            catch (Exception ex)
            {

            }
        }
    }
}

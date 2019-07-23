using System.Web.Http;

namespace EmploymentTracking
{
    public static class WebApiConfig
    {

        public static void Schedule(HttpConfiguration configuration)
        {
            configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
        }
        
    }
}

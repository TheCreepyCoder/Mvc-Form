using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing;

namespace MvcLogin
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("");

      routes.MapRoute(
      name: "Default",
      url : "{controller}/{action}/{id}",
      defaults: new {controller = "Account", action = "Index",
       id = UrlParameter.Optional}
      );
    }
  }
}

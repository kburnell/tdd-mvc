using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using StructureMap;
using TestDrivingMVC.Web.Utility;

namespace TestDrivingMVC.Web {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });
            routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}", defaults: new {id = RouteParameter.Optional});
            routes.MapRoute(name: "Default", url: "{controller}/{action}/{id}", namespaces: new[] {"TestDrivingMVC.Controllers"}, defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional});
        }

        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();        
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            BundleTable.Bundles.RegisterTemplateBundles();
            WireUpDependencyInjection();
            SetControllerFactory();
        }

        private void WireUpDependencyInjection() {
            //ObjectFactory.Initialize(registry => registry.Scan(x => {
            //                                                       x.AssembliesFromApplicationBaseDirectory();
            //                                                       x.WithDefaultConventions();
            //                                                   }));
        }

        private void SetControllerFactory() {
            ControllerBuilder.Current.SetControllerFactory(new ControllerFactory());
        }
    }
}
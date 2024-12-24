using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using MyHybridSite.App_Start;

namespace MyHybridSite
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

            //SqlServerTypes.Utilities.LoadNativeAssemblies(Server.MapPath("~/bin"));


            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //--https://tutorials.tinyappco.com/ASPNET/JQueryScriptResource
            //--https://stackoverflow.com/questions/72874585/what-does-aspnet-scriptmanager-bootstrap-do
            //--https://github.com/OpenTouryoProject/OpenTouryo/issues/200
            JQueryConfig.RegisterJQuery();
            BootstrapConfig.RegisterBootstrap();

            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
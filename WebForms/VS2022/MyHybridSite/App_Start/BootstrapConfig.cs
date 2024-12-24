using System.Web.UI;

namespace MyHybridSite.App_Start
{
    public class BootstrapConfig
    {
        public static void RegisterBootstrap()
        {
            string BootstrapVer = "5.3.2";
            //--<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
            //--https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js
            ScriptManager.ScriptResourceMapping.AddDefinition("bootstrap",
            new ScriptResourceDefinition
            {
                Path = "~/Scripts/bootstrap.min.js",
                DebugPath = "~/Scripts/bootstrap.js",
                CdnPath = "https://cdn.jsdelivr.net/npm/bootstrap@" + BootstrapVer + "/dist/js/bootstrap.bundle.min.js",
                CdnSupportsSecureConnection = true,
                LoadSuccessExpression = "window.jQuery.fn.carousel"
            });
        }
    }
}

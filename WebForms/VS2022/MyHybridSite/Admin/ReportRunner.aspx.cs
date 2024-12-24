//--https://learn.microsoft.com/en-us/sql/reporting-services/application-integration/integrating-reporting-services-using-reportviewer-controls-get-started?view=sql-server-2016
//--https://learn.microsoft.com/en-us/sql/reporting-services/application-integration/using-the-webforms-reportviewer-control?view=sql-server-ver16
//--https://stackoverflow.com/questions/778688/reportviewer-control-height-issue
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyHybridSite.Admin
{
    public partial class ReportRunner : System.Web.UI.Page
    {
        static bool _isSqlTypesLoaded = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!_isSqlTypesLoaded)
            {
                //SqlServerTypes.Utilities.LoadNativeAssemblies(Server.MapPath("~"));
                _isSqlTypesLoaded = true;
            }

            ShowSSRSReport();
        }

        private void ShowSSRSReport()
        {
            try
            {
                ServerReport serverReport = ReportViewer1.ServerReport;

                // Set the report server URL and report path  
                serverReport.ReportServerUrl = new Uri(@"http://sql2012/ReportServer");//report server
                //serverReport.ReportPath = "/AdbookListDemo"; // must ALWAYS begin with a forward slash!!!!
                serverReport.ReportPath = "/Movies/MoviesCharts01"; // must ALWAYS begin with a forward slash!!!!

                // Example passing in Parameters
                //// Create the sales order number report parameter  
                //ReportParameter salesOrderNumber = new ReportParameter();
                //salesOrderNumber.Name = "SalesOrderNumber";
                //salesOrderNumber.Values.Add("SO43661");

                //// Set the report parameters for the report  
                //ReportViewer1.ServerReport.SetParameters(
                //    new ReportParameter[] { salesOrderNumber });
                //ReportViewer1.ServerReport.Refresh();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SSRSReport.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ReportEmployee();
            return View();
        }
        MyDataSet ds = new MyDataSet();
        public ActionResult ReportEmployee()
        {
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(15000);
            reportViewer.Height = Unit.Percentage(15000);
            var connectionString = "Data Source=.;Initial Catalog=DbEmployee;Integrated Security=True";
            SqlConnection conx = new SqlConnection(connectionString);
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Employee_tbt", conx);
            adp.Fill(ds, ds.Employee_tbt.TableName);
            reportViewer.LocalReport.ReportPath = Server.MapPath(@"/MyReport.rdlc");
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("MyDataSet", ds.Tables[0]));
            ViewBag.ReportViewer = reportViewer;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_Project1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.breadcrumb = "<nav class='breadcrumb'><a class='breadcrumb-item active'>Home</a></nav>";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.breadcrumb = "<nav class='breadcrumb'><a class='breadcrumb-item' href='" + Url.Action("Index", "Home") + "'>Home</a> / <span class='breadcrumb-item active;'>About</span></nav>";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.breadcrumb = "<nav class='breadcrumb'><a class='breadcrumb-item' href='" + Url.Action("Index", "Home") + "'>Home</a> / <span class='breadcrumb-item active;'>Contact</span></nav>";
            return View();
        }

        public ActionResult Degrees(string id)
        {
            if (id == "bsis")
            {
                ViewBag.degree = "Bachelor of Science in Information Systems";
                ViewBag.dcoord = "Dr. Conan Albrecht";
                ViewBag.coordtitle = "Professor of Information Systems";
                ViewBag.office = "780 TNRB";
                ViewBag.phd = "<li>PhD, Management Information Systems, University of Arizona, 2000</li>";
                ViewBag.masters = "<li>MAcc, Accounting and Information Systems, Brigham Young University,  1997</li>";
                ViewBag.bachelors = "<li>BS, Accounting and Information Systems, Brigham Young University, 1997</li>";
                ViewBag.coordpic = "http://marriottschool.byu.edu/msmadmin/securefile/empphoto/?file=b0%2F5293.jpg";
                ViewBag.breadcrumb = "<nav class='breadcrumb'><a class='breadcrumb-item' href='" + Url.Action("Index", "Home") + "'>Home</a> / <a class='breadcrumb-item' href='" + Url.Action("Degrees", "Home", new { id = "" }) + "'>Degrees</a> / <span class='breadcrumb-item active;'>BSIS</span></nav>";
            }
            if(id=="mism"){
                ViewBag.degree = "Masters in Information Systems Management";
                ViewBag.dcoord = "Dr. Bonnie Anderson";
                ViewBag.coordtitle = "Associate Professor of Information Systems";
                ViewBag.office = "776 TNRB";
                ViewBag.phd = "<li>PhD, Information Systems, Carnegie Mellon University, 2001</li>";
                ViewBag.masters = "<li>MPhil, Public Policy, Carnegie Mellon University, 2000</li><li>MAcc, Information Systems, Brigham Young University, 1995</li>";
                ViewBag.bachelors = "<li>BS, Accounting, Brigham Young University, 1995</li>";
                ViewBag.coordpic = "https://marriottschool.byu.edu/msmadmin/securefile/empphoto/?file=b0%2F1478.jpg";
                ViewBag.breadcrumb = "<nav class='breadcrumb'><a class='breadcrumb-item' href='" + Url.Action("Index", "Home") + "'>Home</a> / <a class='breadcrumb-item' href='" + Url.Action("Degrees", "Home", new { id = "" }) + "'>Degrees</a> / <span class='breadcrumb-item active;'>MISM</span></nav>";
            }
            if(id != "mism" & id != "bsis") {
                ViewBag.breadcrumb = "<nav class='breadcrumb'><a class='breadcrumb-item' href='" + Url.Action("Index", "Home") + "'>Home</a> / <span class='breadcrumb-item active;'>Degrees</span></nav>";
            }
            
            ViewBag.Message = "Degrees";
            ViewBag.id = id;
            return View("Degrees");
        }






    }
}
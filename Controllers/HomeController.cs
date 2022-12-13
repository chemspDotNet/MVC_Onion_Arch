using MVC_Onion_Arch_DAL.Data;
using MVC_Onion_Arch_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Onion_Arch.Controllers
{
    public class HomeController : Controller
    {
        EmployeeService employeeService = new EmployeeService();

        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";

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
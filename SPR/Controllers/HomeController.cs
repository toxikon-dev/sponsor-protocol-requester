using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using SPR.Filters;
using SPR.Models;

namespace SPR.Controllers
{
    [Authorize]
    [InitializeSimpleMembership]
    public class HomeController : Controller
    {
        bool loggedIn = false;
        public ActionResult Index()
        {
            loggedIn = WebMatrix.WebData.WebSecurity.IsAuthenticated;
            Debug.WriteLine(loggedIn.ToString());
            if (!loggedIn)
            {
                Debug.WriteLine("Redirecting");
                return RedirectToAction("Login", "Account");
            }
            else
            {
                Debug.WriteLine("Redirecting");
                
                return RedirectToAction("MyRequests", "Sponsor");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

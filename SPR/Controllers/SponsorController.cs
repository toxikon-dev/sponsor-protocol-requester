using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPR.Models;
namespace SPR.Controllers
{
    public class SponsorController : Controller
    {
        //
        // GET: /Sponsor/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyRequests()
        {
            Sponsor sponsor = new Sponsor();
            sponsor.OpenRequests.Add(new Request());
            sponsor.OpenRequests.Add(new Request());
            sponsor.OpenRequests.Add(new Request());
            sponsor.OpenRequests.Add(new Request());
            sponsor.Contacts.Add(new Contact());
            sponsor.Contacts.Add(new Contact());
            sponsor.Contacts.Add(new Contact());
            sponsor.Contacts.Add(new Contact());
            return View(sponsor);
        }


        public ActionResult Details(int ID)
        {

            return View();
        }
    }
}

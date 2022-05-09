using project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Signup()
        {
            return View(new Client());

        }
        [HttpPost]
        public ActionResult Signup(Client c)
        {
            if (ModelState.IsValid)
            {
                TMSEntities db = new TMSEntities();
                db.Clients.Add(c);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();

        }
    }
}
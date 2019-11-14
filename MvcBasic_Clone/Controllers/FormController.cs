using MvcBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class FormController : Controller
    {
        private HRContext db = new HRContext();

        // GET: Form
        public ActionResult Index()
        {
            return View(db.infos.ToList());
        }

        public ActionResult Userinfo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Userinfo([Bind(Include = "Id,Name,Phone,Email,Gender")] info info)
        {
            if (ModelState.IsValid)
            {
                db.infos.Add(info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(info);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserData(string name, string phone, string email, string gender)
        {
            info info = new info { Name = name, Phone = phone, Email = email, Gender = gender };

            db.infos.Add(info);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
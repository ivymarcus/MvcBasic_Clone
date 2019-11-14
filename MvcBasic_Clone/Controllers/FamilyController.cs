using MvcBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class FamilyController : Controller
    {
        // GET: Family
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FamilyList()
        {
            List<Family> familys = new List<Family>
            {
                new Family { Id = "F123456789", Name = "David", Phone = "0933-154228", Age = 22, City = "台北" },
                new Family { Id = "F123456789", Name = "Mary", Phone = "0925-157886", Age = 23, City = "新北" },
                new Family { Id = "F123456789", Name = "John", Phone = "0921-335884", Age = 24, City = "台北" },
                new Family { Id = "F123456789", Name = "Cindy", Phone = "0971-628322", Age = 12, City = "台中" },
                new Family { Id = "F123456789", Name = "Rose", Phone = "0933-154228",  Age = 30, City = "高雄" }
            };

            return View(familys);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class WatchController : Controller
    {
        // GET: Watch
        public ActionResult Index()
        {
            return View();
        }

        // WatchPage : 右鍵 -> 新增檢視
        public ActionResult WatchPage()
        {
            return View();
        }
    }
}
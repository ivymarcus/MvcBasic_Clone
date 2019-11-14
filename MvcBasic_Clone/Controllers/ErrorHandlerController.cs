using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class ErrorHandlerController : Controller
    {
        // GET: ErrorHandler
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ErrorMessage()
        {
            // 檢查是否有此 Key ("ErrorMessage")
            if (!TempData.ContainsKey("ErrorMessage"))
            {
                return new EmptyResult(); // 回傳 EmptyResult() 相當於 null
            }

            TempData.Keep();    // 只是系統保留 TempData資料，不要清除 
            //TempData.Keep("ErrorMessage");    // 保留指定的key資料 "ErrorMessage"

            return View();
        }
    }
}
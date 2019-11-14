using MvcBasic_Clone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PassViewData()
        {
            // 為捨麼可以儲存 字串、整數、布林值
            // 因為 資料是以 Object型別 加入
            ViewData["Name"] = "Kevin";     // 儲存字串
            ViewData["Age"] = 33;           // 儲存整數
            ViewData["Single"] = true;      // 儲存 布林值

            return View();
        }

        public ActionResult PassViewBag()
        {
            // 動態產生的，不會有提示 ； 在 html 也不會有提示
            ViewBag.Nickname = "Mary";
            ViewData["nickname"] = "David";
            ViewBag.Height = 168;
            ViewBag.Weight = 52;
            ViewBag.Married = false;


            return View();
        }

        public ActionResult PetShop()
        {
            // 使用 ViewData 傳遞資料到 View
            ViewData["Company"] = "汪星人寵物店";
            // 使用 ViewBag 傳遞資料到 View
            ViewBag.Address = "台北市信義區松山路100號";



            // 宣告一個 List泛型集合，代表 model資料模型
            List<string> petsList = new List<string>();
            petsList.Add("狗");
            petsList.Add("貓");
            petsList.Add("魚");
            petsList.Add("鼠");
            petsList.Add("變色龍");
            

            // 將 petsList 資料模型 指派給 ViewData.Model屬性，傳遞到View
            ViewData.Model = petsList;
            return View();

            // 也可以這樣寫，實際上傳送model物件給View,會更常使用View(petsList)語法取代
            // return View(petsList);
        }

        public ActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限存取系統資料, 請連絡系統管理人員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();

            // RedirectToAction() : 轉向至另一個 Action
            // ErrorMessage : Action 名稱 
            // ErrorHandler : Controller 名稱
            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }

        public ActionResult PassViewModel()
        {
            PeopleViewModel peopleVM = new PeopleViewModel();
            peopleVM.Employees = null;
            peopleVM.Friends = null;

            return View(peopleVM);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcBasic_Clone
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // 忽略掉 .axd的東西
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Mac 的路由
            routes.MapRoute(
                name: "MacRoute",    // 不能重複
                url: "Mac",          // 網址中的名稱 /Mac。
                defaults: new { controller = "Mac", action = "MacPage", id = UrlParameter.Optional }
                // controller = "Mac" => 建立controllers(控制器) 名稱為 MacController
                // action = "MacPage" => 在 "MacController" 裡 新增 "MacPage"方法 回傳值為ActionResult
            );

            // iPad 的路由
            routes.MapRoute(
                name: "iPadRoute",    // 不能重複
                url: "iPad",          // 網址中的名稱 iPad。
                defaults: new { controller = "iPad", action = "iPadPage", id = UrlParameter.Optional }
                // controller = "iPad" => 建立controllers(控制器) 名稱為 iPadController
                // action = "iPadPage" => 在 "iPadController" 裡 新增 "iPadPage"方法 回傳值為ActionResult
            );

            // iPhone 的路由
            routes.MapRoute(
                name: "iPhoneRoute",    // 不能重複
                url: "iPhone",          // 網址中的名稱 /iPhone。
                defaults: new { controller = "iPhone", action = "iPhonePage", id = UrlParameter.Optional }
                // controller = "iPhone" => 建立controllers(控制器) 名稱為 iPhoneController
                // action = "iPhonePage" => 在 "iPadController" 裡 新增 "iPhonePage"方法 回傳值為ActionResult
            );

            // Watch 的路由
            routes.MapRoute(
                name: "WatchRoute",    // 不能重複
                url: "Watch",          // 網址中的名稱 /Watch。
                defaults: new { controller = "Watch", action = "WatchPage", id = UrlParameter.Optional }
                // controller = "Watch" => 建立controllers(控制器) 名稱為 WatchController
                // action = "WatchPage" => 在 "WatchController" 裡 新增 "WatchPage"方法 回傳值為ActionResult
                
            );


            // 預設 "路由"
            routes.MapRoute(
                name: "Default",    // 不能重複
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

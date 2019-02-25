using Batis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCibatis.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (DemoUsersAppService dll = new DemoUsersAppService())
            {
                dll.Insert(new Batis.Models.DemoUsers { Name="Jackie",Password="123"});
                dll.Delete(new { Id=1});
                var all=dll.GetAll(null).ToList();
                var model=dll.Get(new { Id = 2 });
                model.Name = "Jackie2";
                model.Password = "mgcc55881717";
                dll.Update(model);
                model = dll.Get(new { Id = 2 });
            }
                
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
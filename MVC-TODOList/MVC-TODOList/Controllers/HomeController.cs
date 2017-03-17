using MVC_TODOList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TODOList.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddItem(ToDoModel mod)
        {
            if (mod.DeleteKey == 0)
                ToDoModel.todos.Add(ToDoModel.todos.Keys.Any() ? ToDoModel.todos.Keys.Max() + 1 : 1, mod.Item);
            else
            {
                ToDoModel.todos[mod.DeleteKey]= mod.Item;
                mod.DeleteKey = 0;
            }


            return RedirectToAction("Index");
        }

        public ActionResult EditItem(ToDoModel mod)
        {
           // ToDoModel.todos.Remove(mod.DeleteKey);
           // ToDoModel.todos.Add(mod.DeleteKey,mod.Item);
            return View("Index");
        }

        public ActionResult RemoveItem(ToDoModel mod)
        {
            ToDoModel.todos.Remove(mod.DeleteKey);
            mod.DeleteKey = 0;
            return RedirectToAction("Index");
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
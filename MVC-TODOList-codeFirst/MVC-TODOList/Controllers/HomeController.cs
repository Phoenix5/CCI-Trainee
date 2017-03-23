using MVC_TODOList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_TODOList.Models.EF;
using System.Data.Entity.Migrations;


namespace MVC_TODOList.Controllers
{
    public class HomeController : Controller
    {
        taskContext db = new taskContext();
       
        public ActionResult Index()
        {
            ToDoModel.todos=db.task1.ToList();
           // tasks.Add(new Tasks { TaskName = "test" });
          //  db.SaveChanges();

            return View();
        }

        public ActionResult AddItem(ToDoModel mod)
        {

            //     ToDoModel.todos.Add(ToDoModel.todos.Keys.Any() ? ToDoModel.todos.Keys.Max() + 1 : 1, mod.Item);
            //  else
            //  {
            //     ToDoModel.todos[mod.DeleteKey]= mod.Item;
            //     mod.DeleteKey = 0;
            //  }
            // var tasks = db.task1.ToList();
            // tasks.Add(new Tasks { TaskName = mod.Item });
            if (mod.DeleteKey == 0)
            {
                db.task1.Add(new Tasks { TaskName = mod.Item });
                db.SaveChanges();
            }
            else
            {

                var temp=  db.task1.SingleOrDefault(m=>m.Id==mod.DeleteKey);
                temp.TaskName = mod.Item;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult EditItem(ToDoModel mod)
        {
            // ToDoModel.todos.Remove(mod.DeleteKey);
            // ToDoModel.todos.Add(mod.DeleteKey,mod.Item);
          //  var itemToRemove = db.task1.SingleOrDefault(x => x.Id == mod.DeleteKey); //returns a single item.

          //  if (itemToRemove != null)
           // {
                // var temp=  db.task1.SingleOrDefault(m=>m.Id==mod.DeleteKey);
                // temp.TaskName = mod.Item;
                //  db.task1.AddOrUpdate(itemToRemove); //requires using System.Data.Entity.Migrations;
                //  db.task1.Attach(itemToRemove);
                // var entry = db.Entry(itemToRemove);
                // entry.Property(e => e.TaskName).IsModified = true;
                // other changed properties
               // Tasks e = db.task1.Find(mod.DeleteKey);
              //  e.TaskName =mod.Item;
             //   db.task1.Update(e);
            //    db.SaveChanges();


             //  db.SaveChanges();

           // }
            return View("Index");
        }

        public ActionResult RemoveItem(ToDoModel mod)
        {
           // ToDoModel.todos.Remove(mod.DeleteKey);
          //  mod.DeleteKey = 0;
           // db.task1.Where(m => m.Id == mod.DeleteKey);
            //  db.task1.Remove(db.task1);
            var itemToRemove = db.task1.SingleOrDefault(x => x.Id == mod.DeleteKey); //returns a single item.

            if (itemToRemove != null)
            {
                db.task1.Remove(itemToRemove);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult SearchToDoList(ToDoModel mod)
        {
         //   foreach (var description in ToDoModel.todos)
         //   {
          //      if (mod.Item == description.)
          //      {
          //          mod.DeleteKey = description.Key;
          //      }
           // }

           // return PartialView("_partialView",mod);
            return View("Index", mod);
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
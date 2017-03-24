using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI_Basic.Controllers
{
    public class ToDoController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View("ToDoView");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

using WebAPI_Basic.Models;

namespace WebAPI_Basic.API
{
    public class ToDoAPIController : ApiController
    {
        TaskContext db = new TaskContext();

        // GET: api/CarDetails
        [HttpGet]
        public IEnumerable<Tasks> GetToDoList()
        {
           
            List<Tasks> li = db.task.ToList(); 


            return li;
        }

        // GET: api/CarDetails/5
        [HttpGet]
        public IEnumerable<Tasks> Get(int id)
        {
            
            List<Tasks> li = db.task.ToList();
            

            return li.Where(n=>n.Id==id);
        }

        // POST: api/CarDetails
        [HttpPost]
        public int PostToDo([FromBody]Tasks cs)
        {
            Tasks t = new Tasks() { TaskName=cs.TaskName};
            db.task.Add(t);
            db.SaveChanges();
            return 1;
         //   RedirectToRoute("Default",new { });
        }

        // PUT: api/CarDetails/5
        [HttpPut]
        public int PutToDo(int id, [FromBody]string value)
        {
            var temp = db.task.SingleOrDefault(m => m.Id == id);
            temp.TaskName = value;
            db.SaveChanges();
            return 1;
        }

        // DELETE: api/CarDetails/5
        [HttpDelete]
        public int DeleteToDo(int id)
        {
            var itemToRemove = db.task.SingleOrDefault(x => x.Id == id); //returns a single item.

            if (itemToRemove != null)
            {
                db.task.Remove(itemToRemove);
                db.SaveChanges();
            }
            return 1;
        }
    }
}

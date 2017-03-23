using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_TODOList.Models.EF;

namespace MVC_TODOList.Models
{
    public class ToDoModel
    {
      //  public int check=222;
        public string Item { get; set; }
        public int DeleteKey { get; set; }
        public static List<Tasks> todos { get; set; }

        static ToDoModel()
        {
            todos = new List<Tasks>();
        }
    }
}
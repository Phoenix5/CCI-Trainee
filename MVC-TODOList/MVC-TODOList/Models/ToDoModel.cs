using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_TODOList.Models
{
    public class ToDoModel
    {
        public int check=222;
        public string Item { get; set; }
        public int DeleteKey { get; set; }
        public static Dictionary<int,string> todos { get; set; }

        static ToDoModel()
        {
            todos = new Dictionary<int,string>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_TODOList.Models.EF
{
    public class taskContext:DbContext
    {
        public taskContext() :base("Name=taskContext")
        {
        }
        public DbSet<Tasks> task1 {get;set; }
    }

    public class taskDBCreator : DropCreateDatabaseIfModelChanges<taskContext>
    {

    }
}
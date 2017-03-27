using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI_Basic.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext() :base("Name=taskContext")
        {
        }
        public DbSet<Tasks> task { get; set; }
    }

    public class taskDBCreator : DropCreateDatabaseIfModelChanges<TaskContext>
    {

    }
}
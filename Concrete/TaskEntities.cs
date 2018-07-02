using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class TaskEntities : DbContext
    {
        public TaskEntities()
            : base("Server=DUCTRUONG\\SQLEXPRESS;Database=TODO Repository;")
        {

        }
        public DbSet<Task> Tasks { get; set; }
    }
}

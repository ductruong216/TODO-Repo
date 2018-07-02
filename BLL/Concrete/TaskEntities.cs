using System.Data.Entity;

namespace TODO.Domain.Concrete
{
    public class TaskEntities : DbContext , IDbContext
    {
        public TaskEntities()
            : base("Server=DUCTRUONG\\SQLEXPRESS;Database=TODO Repository;Integrated Security=True;") { }

        public DbSet<Task> Tasks { get; set; }
    }
}

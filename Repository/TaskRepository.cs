using TODO.Domain;
using TODO.Domain.Concrete;

namespace Repository
{
    public class TaskRepository : GenericRepository<Task>
    {
        public TaskRepository(TaskEntities context) : base(context)
        {
           
        }
    }
}
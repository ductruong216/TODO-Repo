using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaskRepository : ITaskRepository, IDisposable
    {
        private TaskEntities context = new TaskEntities();
        public void DeleteTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task GeTasktByID(int taskId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> GetTasks()
        {
            throw new NotImplementedException();
        }

        public void InsertTask(Task task)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateTasks(Task task)
        {
            throw new NotImplementedException();
        }
    }
}

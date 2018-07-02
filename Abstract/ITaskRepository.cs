using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ITaskRepository : IDisposable
    {
        IEnumerable<Task> GetTasks();
        Task GeTasktByID(int taskId);
        void InsertTask(Task task);
        void DeleteTask(int taskId);
        void UpdateTasks(Task task);
        void Save();

    }
}

using Repository;
using System.Collections.Generic;
using System.Windows.Forms;
using TODO.Domain;
using TODO.Domain.Concrete;
using TODO.Domain.Interfaces;

namespace Service
{

    public class TaskService : BaseService<Task, TaskEntities>, ITaskService
    {
        public TaskService()
        {
            GetTaskList();
        }

        public IList<Task> GetTaskList()
        {
            return GetList();
        }

        public void DeleteTask(string taskTitle)
        {
            Delete(taskTitle);
        }

        public void UpdateTask(Task task)
        {
            Update(task);
        }

        public void AddTask(Task task)
        {
            try
            {
                Add(task);
            }
            catch
            {
                MessageBox.Show(
                    "Value too long",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        public Task GetTaskByTitle(string taskTitle)
        {
            var task = GetByID(taskTitle);
            return task;
        }
    }
}

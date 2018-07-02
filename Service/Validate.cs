using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Domain;

namespace Service
{
    public class Validate
    {
        public bool ValidateTask(Task task, IList<Task> listTask)
        {
            var taskTemp = listTask.FirstOrDefault(x => x.Title == task.Title);

            if (taskTemp != null)
            {
                return false;
            }
            return true;
        }
    }
}
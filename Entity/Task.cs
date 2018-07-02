using DTO;
using System;

namespace DAL.Entity
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateFinish { get; set; }
        public TaskType Type { get; set; }

        public Task() { }
        public Task(string title, string desription, DateTime dayCreate, DateTime dayFinish)
        {
            Title = title;
            Description = desription;
            DateCreate = dayCreate;
            DateFinish = dayFinish;
        }
    }
}

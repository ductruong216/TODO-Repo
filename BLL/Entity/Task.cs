using System;
using System.ComponentModel.DataAnnotations;

namespace TODO.Domain
{
    public partial class Task
    {
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateFinish { get; set; }
        public string Type { get; set; }
    }
}

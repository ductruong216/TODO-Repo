using System;
using TODO.Domain;

namespace GUI
{
    public class Helper
    {
        public Helper() { }
        internal TaskType ConvertToEnum(string type)
        {
            return (TaskType)Enum.Parse(typeof(TaskType), type);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ToDo.App.Domain;

namespace ToDo.App.WebApp.Models
{
    public class NewTaskModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public double AverageFreeTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public List<_Task_> MyTasks { get; set; }
    }
}

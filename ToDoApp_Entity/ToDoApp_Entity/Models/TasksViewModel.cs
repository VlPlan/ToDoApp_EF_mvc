using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.App.Domain;

namespace ToDo.App.WebApp.Models
{
    public class TasksViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }


    }
}

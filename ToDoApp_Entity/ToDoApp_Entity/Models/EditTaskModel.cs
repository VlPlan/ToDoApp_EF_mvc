using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.App.Domain;

namespace ToDo.App.WebApp.Models
{
    public class EditTaskModel
    {
        public _Task_ Task { get; set; }
        public List<Status> TaskStatuses { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ToDo.App.Domain.Models
{
    public class SubtaskFromTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public _Task_ Task { get; set; }
        public int TaskId { get; set; }
        public SubTask SubTask { get; set; }
        public int SubTaskId { get; set; }
    }
}

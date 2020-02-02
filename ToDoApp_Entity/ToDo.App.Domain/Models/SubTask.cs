using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ToDo.App.Domain.Models;

namespace ToDo.App.Domain
{
    public class SubTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public _Task_ Task { get; set; }
        public List<SubtaskFromTask> SubtasksFromTask { get; set; }
        [ForeignKey("_Task_Id")]
        public int? _Task_Id { get; set; }
    }
}

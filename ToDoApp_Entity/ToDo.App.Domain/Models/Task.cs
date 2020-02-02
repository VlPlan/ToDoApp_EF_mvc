using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace ToDo.App.Domain
{
    public class _Task_
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PriorityLevel PriorityLevel { get; set; }
        public Status Status { get; set; }
        public Type Type { get; set; }
        public List<SubTask> SubTasks { get; set; }
        public int UserId { get; set; }
        [ForeignKey("Subtask")]
        public int? SubtaskId { get; set; }
        public virtual SubTask Subtask { get; set; }




    }
}

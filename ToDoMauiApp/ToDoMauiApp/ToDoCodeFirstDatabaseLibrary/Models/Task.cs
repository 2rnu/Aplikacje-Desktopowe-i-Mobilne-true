using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCodeFirstDatabaseLibrary.Models
{
    internal class Task
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public required string TaskTextContent { get; set; }
        public bool IsTaskDone {  get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Entities
{
    public class Priority
    {
        public Priority(Priority priority)
        {
            Description = priority.Description;
        }

        public Priority(){ }

        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Description { get; set; }
    }
}

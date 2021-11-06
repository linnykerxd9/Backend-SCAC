using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Entities
{
    public class Status
    {
        public Status(Status status)
        {
            Description = status.Description;
        }

        public Status(){ }

        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Description { get; set; }
    }
}

using SCACback.src.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Entities
{
    public class Event
    {
        public Event(Event item)
        {
            NameResponsible = item.NameResponsible;
            Date = item.Date;
            Hour = item.Hour;
            Description = item.Description;
            IdStatus = item.IdStatus;
        }

        public Event() { }

        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string NameResponsible { get; set; }

        [MaxLength(10)]
        [Required]
        public string Date { get; set; }
        [MaxLength(5)]
        [Required]
        public string Hour { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public int IdStatus { get; set; }

        [ForeignKey("IdStatus")]
        public Status Status { get; set; }

        public EventDTO ToDTO()
        {
            EventDTO parseDTO = new()
            {
                NameResponsible = this.NameResponsible,
                Date = this.Date,
                Hour = this.Hour,
                Description = this.Description,
                Status = this.Status
            };

            return parseDTO;
        }
    }
}

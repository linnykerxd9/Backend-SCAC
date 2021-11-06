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
        public string NameResponsible { get; set; }

        [MaxLength(10)]
        public string Date { get; set; }
        [MaxLength(5)]
        public string Hour { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public int IdStatus { get; set; }

        [ForeignKey("IdStatus")]
        public Status Status { get; set; }

        public EventDTO ToDTO()
        {
            EventDTO parseDTO = new EventDTO();
            parseDTO.NameResponsible = this.NameResponsible;
            parseDTO.Date = this.Date;
            parseDTO.Hour = this.Hour;
            parseDTO.Description = this.Description;
            parseDTO.Status = this.Status;

            return parseDTO;
        }
    }
}

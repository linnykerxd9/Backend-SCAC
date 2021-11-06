using SCACback.src.DTO;
using System;
using System.Collections.Generic;
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

        public int Id { get; set; }
        public string NameResponsible { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public string Description { get; set; }
        public int IdStatus { get; set; }
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

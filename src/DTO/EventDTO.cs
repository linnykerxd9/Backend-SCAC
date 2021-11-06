using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.DTO
{
    public class EventDTO
    {
        public string NameResponsible { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string NameResponsible { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public string Description { get; set; }
        public int IdStatus { get; set; }
        public Status Status { get; set; }
    }
}

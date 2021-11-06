using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.DTO
{
    public class CommunityLeaderDTO
    {
        public string FullName { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }

    }
}

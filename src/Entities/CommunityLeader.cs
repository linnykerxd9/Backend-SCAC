using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Entities
{
    public class CommunityLeader
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string EntryDate { get; set; }
        public string? ExitDate { get; set; }

    }
}

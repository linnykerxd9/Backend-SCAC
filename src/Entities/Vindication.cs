using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Entities
{
    public class Vindication
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string CompletionDate { get; set; }
        public string OpenDate { get; set; }
        public int IdLeader { get; set; }
        public int IdResident { get; set; }

        public int IdStatus { get; set; }
        public int? IdOrgPublic { get; set; }
        public int IdPriority { get; set; }
        public CommunityLeader CommunityLeader { get; set; }
        public Resident Resident { get; set; }
        public Status Status { get; set; }
        public OrgPublic OrgPublic { get; set; }
        public Priority Priority { get; set; }


    }
}

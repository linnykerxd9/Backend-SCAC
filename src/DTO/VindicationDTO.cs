using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.DTO
{
    public class VindicationDTO
    {
        public string Description { get; set; }
        public string CompletionDate { get; set; }
        public string OpenDate { get; set; }

        public CommunityLeader CommunityLeader { get; set; }
        public Resident Resident { get; set; }
        public Status Status { get; set; }
        public OrgPublic OrgPublic { get; set; }
        public Priority Priority { get; set; }


    }
}

using SCACback.src.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Entities
{
    public class Vindication
    {
        public Vindication(Vindication vindication)
        {
            Description = vindication.Description;
            CompletionDate = vindication.CompletionDate;
            OpenDate = vindication.OpenDate;
            IdLeader = vindication.IdLeader;
            IdResident = vindication.IdResident;
            IdStatus = vindication.IdStatus;
            IdOrgPublic = vindication.IdOrgPublic;
            IdPriority = vindication.IdPriority;
        }

        public Vindication() { }

        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        [Required]
        public string Description { get; set; }
        [MaxLength(10)]
        public string CompletionDate { get; set; }
        [MaxLength(10)]
        [Required]
        public string OpenDate { get; set; }
        public int IdLeader { get; set; }
        public int IdResident { get; set; }

        public int IdStatus { get; set; }
        public int? IdOrgPublic { get; set; }
        public int IdPriority { get; set; }

        [ForeignKey("IdLeader")]
        public CommunityLeader CommunityLeader { get; set; }
        [ForeignKey("IdResident")]
        public Resident Resident { get; set; }
        [ForeignKey("IdStatus")]
        public Status Status { get; set; }
        [ForeignKey("IdOrgPublic")]
        public OrgPublic OrgPublic { get; set; }
        [ForeignKey("IdPriority")]
        public Priority Priority { get; set; }

        public VindicationDTO ToDTO()
        {
            VindicationDTO parseDTO = new VindicationDTO();
            parseDTO.Description = this.Description;
            parseDTO.CompletionDate = this.CompletionDate;
            parseDTO.OpenDate = this.OpenDate;
            parseDTO.CommunityLeader = this.CommunityLeader;
            parseDTO.Resident = this.Resident;
            parseDTO.Status = this.Status;
            parseDTO.OrgPublic = this.OrgPublic;
            parseDTO.Priority = this.Priority;

            return parseDTO;

        }
    }
}

using SCACback.src.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Entities
{
    public class CommunityLeader
    {
        public CommunityLeader(CommunityLeader leader)
        {
            FullName = leader.FullName;
            Rg = leader.Rg;
            Cpf = leader.Cpf;
            Login = leader.Login;
            Password = leader.Password;
            EntryDate = DateTime.Now;
        }

        public CommunityLeader(){ }

        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        public string FullName { get; set; }

        [MaxLength(9)]
        [MinLength(7)]
        public string Rg { get; set; }

        [MaxLength(15)]
        [MinLength(12)]
        public string Cpf { get; set; }


        [MaxLength(20)]
        [MinLength(8)]
        public string Login { get; set; }

        [MinLength(8)]
        public string Password { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }

        public void updateExit()
        {
            this.ExitDate = DateTime.Now;
        }

        public CommunityLeaderDTO ToDTO()
        {
            CommunityLeaderDTO parseDTO = new CommunityLeaderDTO();
            parseDTO.FullName = this.FullName;
            parseDTO.Rg = this.Rg;
            parseDTO.Cpf = this.Cpf;
            parseDTO.EntryDate = this.EntryDate;
            parseDTO.ExitDate = this.ExitDate;

            return parseDTO;
            
        }
    }
}

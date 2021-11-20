using Backend_SCAC.src.Interfaces;
using Backend_SCAC.src.Repositories;
using Microsoft.EntityFrameworkCore;
using SCACback.src.DTO;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Services
{
    public class ServiceCommunityLeader : IService<CommunityLeaderDTO, CommunityLeader>,IServiceGet<CommunityLeader>
    {
        private readonly Repository repository;

        public ServiceCommunityLeader(Repository repository)
        {
            this.repository = repository;

            var migrationsPending = repository.Database.GetPendingMigrations();
            if(migrationsPending.Count() > 0)
            {
                repository.Database.Migrate();
            }
        }



        public async Task<CommunityLeaderDTO> Create(CommunityLeader item)
        {
            repository.CommunityLeader.Add(item);
            await repository.SaveChangesAsync();

            return item.ToDTO();
        }

        public async Task<CommunityLeaderDTO> Delete(CommunityLeader item)
        {
            repository.CommunityLeader.Remove(item);
            await repository.SaveChangesAsync();

            return item.ToDTO();
        }

        public List<CommunityLeader> GetAll()
        {
            List<CommunityLeader> all = repository.CommunityLeader.ToList();

            return all;
        }

        public async Task<CommunityLeader> GetById(int id)
        {
            CommunityLeader communityLeader = await repository.CommunityLeader.FirstOrDefaultAsync(h => h.Id == id);
            return communityLeader;
        }

        public async Task<CommunityLeaderDTO> Update(CommunityLeader item)
        {
            repository.CommunityLeader.Update(item);
            await repository.SaveChangesAsync();
            return item.ToDTO();
        }

        public async Task<CommunityLeader> Login(string login,string password)
        {
           CommunityLeader query = await repository.CommunityLeader.Where(l => l.Login == login && l.Password == password && l.ExitDate == null).FirstOrDefaultAsync();
            return query;
        }
    }
}

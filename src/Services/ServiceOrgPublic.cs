using Backend_SCAC.src.Interfaces;
using Backend_SCAC.src.Repositories;
using Microsoft.EntityFrameworkCore;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Services
{
    public class ServiceOrgPublic : IService<OrgPublic, OrgPublic>, IServiceGet<OrgPublic>
    {
        private readonly Repository repository;

        public ServiceOrgPublic(Repository repository)
        {
            this.repository = repository;
        }

        public async Task<OrgPublic> Create(OrgPublic item)
        {
            repository.OrgPublic.Add(item);
            await repository.SaveChangesAsync();

            return item;
        }

        public async  Task<OrgPublic> Delete(OrgPublic item)
        {
            repository.OrgPublic.Remove(item);
            await repository.SaveChangesAsync();

            return item;
        }

        public List<OrgPublic> GetAll()
        {
            List<OrgPublic> all = repository.OrgPublic.ToList();

            return all;
        }

        public  async Task<OrgPublic> GetById(int id)
        {
            OrgPublic orgPublic = await repository.OrgPublic.FirstOrDefaultAsync(h => h.Id == id);
            return orgPublic;
        }

        public async Task<OrgPublic> Update(OrgPublic item)
        {
            repository.OrgPublic.Update(item);
            await repository.SaveChangesAsync();
            return item;
        }
    }
}

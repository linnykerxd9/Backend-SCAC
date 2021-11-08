﻿using Backend_SCAC.src.Interfaces;
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
    public class ServiceCommunityLeader : IService<CommunityLeaderDTO, CommunityLeader>,IServiceGetAll<CommunityLeader>
    {
        private readonly Repository repository;

        public ServiceCommunityLeader(Repository repository)
        {
            this.repository = repository;
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

        public async Task<CommunityLeaderDTO> GetById(int id)
        {
            CommunityLeader communityLeader = await repository.CommunityLeader.FirstOrDefaultAsync(h => h.Id == id);
            return communityLeader.ToDTO();
        }

        public async Task<CommunityLeaderDTO> Update(CommunityLeader item)
        {
            repository.CommunityLeader.Update(item);
            await repository.SaveChangesAsync();
            return item.ToDTO();
        }
    }
}
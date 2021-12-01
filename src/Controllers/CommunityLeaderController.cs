using Backend_SCAC.src.Services;
using Microsoft.AspNetCore.Mvc;
using SCACback.src.DTO;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Controllers
{
    [ApiController]
    [Route("api/v1/leader")]
    public class CommunityLeaderController
    {
        private readonly ServiceCommunityLeader service;

        public CommunityLeaderController(ServiceCommunityLeader service)
        {
            this.service = service;
        }

        [HttpPost]
        public Task<CommunityLeaderDTO> Create([FromBody] CommunityLeader item)
        {
            return service.Create(item);
        }

        [HttpGet]
        public List<CommunityLeader> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("{id:int}")]
        public Task<CommunityLeader> GetById([FromRoute] int id)
        {
            return service.GetById(id);
        }

        [HttpPut]
        public Task<CommunityLeaderDTO> UpdateEvent([FromBody] CommunityLeader item)
        {
            return service.Update(item);
        }

        [HttpDelete]
        public Task<CommunityLeaderDTO> DeleteEvent([FromBody] CommunityLeader item)
        {
            return service.Delete(item);
        }

        [HttpPut("exitDate")]
        public Task<CommunityLeaderDTO> UpdateExitDate(CommunityLeader leader)
        {
            leader.UpdateExit();
            return service.Update(leader);
        }

        [HttpGet("login")]
        public Task<CommunityLeader> Login(string login,string password)
        {
            return  service.Login(login, password);
            
        }
    }
}

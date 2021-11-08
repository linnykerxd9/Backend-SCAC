using Backend_SCAC.src.Services;
using Microsoft.AspNetCore.Mvc;
using SCACback.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Controllers
{
     [ApiController]
     [Route("api/v1/orgPublic")]
    public class OrgPublicController
    {
        private readonly ServiceOrgPublic service;

        public OrgPublicController(ServiceOrgPublic service)
        {
            this.service = service;
        }

        [HttpPost]
        public Task<OrgPublic> Create([FromBody] OrgPublic item)
        {
            return service.Create(item);
        }

        [HttpGet]
        public List<OrgPublic> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet("{id:int}")]
        public Task<OrgPublic> GetById([FromRoute] int id)
        {
            return service.GetById(id);
        }

        [HttpPut]
        public Task<OrgPublic> UpdateEvent([FromBody] OrgPublic item)
        {
            return service.Update(item);
        }

        [HttpDelete]
        public Task<OrgPublic> DeleteEvent([FromBody] OrgPublic item)
        {
            return service.Delete(item);
        }
    }
}

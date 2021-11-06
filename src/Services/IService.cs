using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Services
{
    public interface IService<T,R>
    {
        public  Task<T> Create(R item);
        public  Task<ActionResult<T>> Delete(R item);
        public  Task<ActionResult<T>> Update(R item);
        public  List<Task<ActionResult<T>>> GetAll(R item);
        public  Task<ActionResult<T>> GetById(R item);

    }
}

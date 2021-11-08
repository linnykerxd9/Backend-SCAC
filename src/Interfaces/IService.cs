using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Interfaces
{
    public interface IService<T,R>
    {
        public  Task<T> Create(R item);
        public  Task<T> Delete(R item);
        public  Task<T> Update(R item);
     

    }
}

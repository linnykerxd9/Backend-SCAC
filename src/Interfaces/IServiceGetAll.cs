using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_SCAC.src.Interfaces
{
    interface IServiceGetAll<T>
    {
        public List<T> GetAll();
    }
}

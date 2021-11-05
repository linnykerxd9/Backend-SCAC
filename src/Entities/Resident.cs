using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Entities
{
    public class Resident
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Birthday { get; set; }
        public string  Telephone { get; set; }
        public char Sex { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Complement { get; set; }


    }
}

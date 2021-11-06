using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Entities
{
    public class Resident
    {
        public Resident(Resident resident)
        {
            Id = resident.Id;
            FullName = resident.FullName;
            Rg = resident.Rg;
            Cpf = resident.Cpf;
            Birthday = resident.Birthday;
            Telephone = resident.Telephone;
            Sex = resident.Sex;
            Address = resident.Address;
            District = resident.District;
            Number = resident.Number;
            City = resident.City;
            Uf = resident.Uf;
            Cep = resident.Cep;
            Complement = resident.Complement;
        }

        public Resident(){ }

        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        [Required]
        public string FullName { get; set; }
        [MaxLength(9)]
        [MinLength(7)]
        [Required]
        public string Rg { get; set; }

        [MaxLength(15)]
        [MinLength(12)]
        [Required]
        public string Cpf { get; set; }

        [MaxLength(10)]
        [Required]
        public string Birthday { get; set; }
        [MaxLength(15)]
        [Required]
        public string  Telephone { get; set; }
        [MaxLength(1)]
        [MinLength(1)]
        [Required]
        public char Sex { get; set; }
        [MaxLength(50)]
        [Required]
        public string Address { get; set; }
        [MaxLength(50)]
        [Required]
        public string District { get; set; }
        [MaxLength(10)]
        [Required]
        public string Number { get; set; }
        [MaxLength(50)]
        [Required]
        public string City { get; set; }
        [MaxLength(2)]
        [MinLength(2)]
        [Required]
        public string Uf { get; set; }
        [MaxLength(9)]
        [MinLength(8)]
        [Required]
        public string Cep { get; set; }
        [MaxLength(100)]
        public string Complement { get; set; }


    }
}

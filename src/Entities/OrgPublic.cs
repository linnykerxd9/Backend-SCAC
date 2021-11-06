using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCACback.src.Entities
{
    public class OrgPublic
    {
        public OrgPublic(OrgPublic org)
        {
            Name = org.Name;
            Responsible = org.Responsible;
            Email = org.Email;
            Telephone = org.Telephone;
        }

        public OrgPublic() { }

        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Responsible { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string Telephone { get; set; }

    }
}

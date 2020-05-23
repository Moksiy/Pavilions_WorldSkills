

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pavilions_WS.Models
{
    public class Tenantry
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }
    }
}

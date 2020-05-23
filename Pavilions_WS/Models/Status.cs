using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pavilions_WS.Models
{
    public class Status
    {
        [Key]
        public int ID { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<ShoppingCenter> ShoppingCenters { get; set; }
        public virtual ICollection<Rent> Rents { get; set; }
        public virtual ICollection<Pavilion> Pavilions { get; set; }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pavilions_WS.Models
{
    public class Pavilion
    {        
        public string Name { get; set; }
        [Key]
        public string Number { get; set; }
        public int Floor { get; set; }
        public int StatusID { get; set; }
        public double? Square { get; set; }
        public double? Cost { get; set; }
        public double? Coefficient { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }
        public virtual Status Status { get; set; }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pavilions_WS.Models
{
    public class ShoppingCenter
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int StatusID { get; set; }
        public int Quantity { get; set; }
        public int CityID { get; set; }
        public double Cost { get; set; }
        public double? Coefficient { get; set; }
        public int Floors { get; set; }
        public byte[] Photo { get; set; } 

        public virtual ICollection<Rent> Rents { get; set; }

        public virtual City City { get; set; }
        public virtual Status Status { get; set; }
    }
}

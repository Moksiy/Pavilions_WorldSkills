using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pavilions_WS.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }

        public string CityName { get; set; }

        public virtual ICollection<ShoppingCenter> ShoppingCenters { get; set; }
    }
}

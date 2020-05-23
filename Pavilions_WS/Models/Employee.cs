

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pavilions_WS.Models
{
    public class Employee
    {        
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        [Key]
        public int ID { get; set; }
        public byte[] Photo { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }
    }
}

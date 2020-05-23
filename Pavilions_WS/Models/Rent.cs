using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Pavilions_WS.Models
{
    public class Rent
    {
        [Key]
        public int ID { get; set; }
        public int TenantryID { get; set; }
        public int ShoppingCenterID { get; set; }
        public int EmployeeID { get; set; }
        public string PavilionID { get; set; }
        public int StatusID { get; set; }
        public DateTime? StartRent { get; set; }
        public DateTime? EndRent { get; set; }

        public virtual ShoppingCenter ShoppingCenter { get; set; }
        public virtual Status Status { get; set; }
        public virtual Pavilion Pavilion { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Tenantry Tenantry { get; set; }
    }
}

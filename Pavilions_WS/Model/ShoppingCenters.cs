//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pavilions_WS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShoppingCenters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShoppingCenters()
        {
            this.Rent = new HashSet<Rent>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int Quantity { get; set; }
        public int City { get; set; }
        public decimal Cost { get; set; }
        public Nullable<float> Coefficient { get; set; }
        public int Floors { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Cities Cities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }
        public virtual Statuses Statuses { get; set; }
    }
}
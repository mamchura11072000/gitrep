//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lead()
        {
            this.Call = new HashSet<Call>();
        }
    
        public int ID { get; set; }
        public string Phone { get; set; }
        public int UserID { get; set; }
        public double HandlingObjections { get; set; }
        public double SellTechniques { get; set; }
        public double ProductKnowledge { get; set; }
        public string Comment { get; set; }
        public System.DateTime CreateDateTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Call> Call { get; set; }
        public virtual User User { get; set; }
    }
}

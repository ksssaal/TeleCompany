//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeleCompany
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telecast
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Telecast()
        {
            this.PreparationProgram = new HashSet<PreparationProgram>();
        }
    
        public int id_telecast { get; set; }
        public string NameTransfers { get; set; }
        public System.TimeSpan Duration { get; set; }
        public int id_AgeRestrictions { get; set; }
    
        public virtual AgeRestrictions AgeRestrictions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreparationProgram> PreparationProgram { get; set; }
    }
}
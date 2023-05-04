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
    
    public partial class Advertising
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Advertising()
        {
            this.CheckingAds = new HashSet<CheckingAds>();
            this.PreparationProgram = new HashSet<PreparationProgram>();
            this.PurchaseAds = new HashSet<PurchaseAds>();
        }
    
        public int id_advertising { get; set; }
        public string Name { get; set; }
        public string Product { get; set; }
        public string Wishes { get; set; }
        public int id_DesiredDisplayTime { get; set; }
        public int id_AgeRestrictions { get; set; }
    
        public virtual AgeRestrictions AgeRestrictions { get; set; }
        public virtual DesiredDisplayTime DesiredDisplayTime { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckingAds> CheckingAds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreparationProgram> PreparationProgram { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseAds> PurchaseAds { get; set; }
    }
}

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
    
    public partial class InternalCurrency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InternalCurrency()
        {
            this.PurchaseAds = new HashSet<PurchaseAds>();
            this.PurchaseOfCurrency = new HashSet<PurchaseOfCurrency>();
        }
    
        public int id_InternalCurrency { get; set; }
        public string NameCurrency { get; set; }
        public Nullable<decimal> Balance { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseAds> PurchaseAds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOfCurrency> PurchaseOfCurrency { get; set; }
    }
}
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
    
    public partial class PurchaseAds
    {
        public int id_PurchaseAds { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public System.TimeSpan Duration { get; set; }
        public int id_InternalCurrency { get; set; }
        public int id_advertising { get; set; }
        public int id_Manager { get; set; }
    
        public virtual Advertising Advertising { get; set; }
        public virtual InternalCurrency InternalCurrency { get; set; }
    }
}

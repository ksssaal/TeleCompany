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
    
    public partial class ResultChecking
    {
        public int id_ResultChecking { get; set; }
        public string Result { get; set; }
        public int id_AgeRestrictions { get; set; }
        public int id_ChekingAge { get; set; }
    
        public virtual AgeRestrictions AgeRestrictions { get; set; }
        public virtual CheckingAgeLimit CheckingAgeLimit { get; set; }
    }
}
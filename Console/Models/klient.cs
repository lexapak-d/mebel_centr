//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Console.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class klient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public klient()
        {
            this.otzivi = new HashSet<otzivi>();
        }
    
        public int Id_klient { get; set; }
        public string imya { get; set; }
        public string familiya { get; set; }
        public string otchestvo { get; set; }
        public Nullable<decimal> telefon { get; set; }
        public string adres { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<otzivi> otzivi { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mebel_centr.Pages.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class otzivi
    {
        public int id_otziv { get; set; }
        public int id_produkt { get; set; }
        public int id_klienta { get; set; }
        public decimal ocenka { get; set; }
        public string text_otziva { get; set; }
    
        public virtual klient klient { get; set; }
        public virtual produkt produkt { get; set; }
    }
}

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
    
    public partial class kategory_produkt
    {
        public int id_produkt_kategory { get; set; }
        public string nazvanie { get; set; }
        public string opisanie { get; set; }
        public int id_produkt { get; set; }
    
        public virtual produkt produkt { get; set; }
    }
}
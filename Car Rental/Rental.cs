//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car_Rental
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    
    public partial class Rental
    {
        [Browsable(false)]
        public int id { get; set; }
        [DisplayName("Debut")]
        public Nullable<System.DateTime> date_from { get; set; }
        [DisplayName("Fin")]
        public Nullable<System.DateTime> date_to { get; set; }
        [DisplayName("Prix")]
        public Nullable<decimal> price { get; set; }
        [Browsable(false)]
        public string client { get; set; }
        [Browsable(false)]
        public string car { get; set; }
    
        [DisplayName("Voiture")]
        public virtual Car Car1 { get; set; }
        [DisplayName("Client")]
        public virtual Client Client1 { get; set; }
    }
}

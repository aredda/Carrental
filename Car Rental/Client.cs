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
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Rentals = new HashSet<Rental>();
        }
    
        [DisplayName("CIN")]
        public string cin { get; set; }
        [Browsable(false)]
        [DisplayName("Prenom")]
        public string first_name { get; set; }
        [Browsable(false)]
        [DisplayName("Nom")]
        public string last_name { get; set; }
        [DisplayName("Telephone")]
        public string telephone { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Adresse")]
        public string adresse { get; set; }
        [DisplayName("Nom Complet")]
        public string full_name
        {
            get {
                return first_name + " " + last_name;
            }
        }
    
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }

        public override string ToString()
        {
            return full_name;
        }
    }
}

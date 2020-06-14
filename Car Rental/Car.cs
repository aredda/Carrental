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
using System.ComponentModel.DataAnnotations;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.Rentals = new HashSet<Rental>();
        }
    
        [DisplayName("Matricule")]
        public string matricule { get; set; }
        [DisplayName("Marque")]
        public string mark { get; set; }
        [DisplayName("Mileage")]
        public Nullable<double> mileage { get; set; }
        
        [Browsable(false)]
        public Nullable<int> model { get; set; }
        
        [DisplayName("Model")]
        public virtual Model Model1 { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }

        public override string ToString()
        {
            return matricule + " (" + Model1.ToString() + ")";
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VajaMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Dijak
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dijak()
        {
            this.DijakPodročje = new HashSet<DijakPodročje>();
            this.IzvedbaDijak = new HashSet<IzvedbaDijak>();
            this.PlanDijak = new HashSet<PlanDijak>();
        }
    
        public int DijID { get; set; }
        [Display(Name ="Ime")]
        public string DijIme { get; set; }
        [Display(Name ="Priimek")]
        public string DijPriimek { get; set; }
        public string DijRazred { get; set; }
        [Display(Name ="Datum rojstva")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyy}")]
        public Nullable<System.DateTime> DijDatumRojstva { get; set; }
        public byte[] DijaSlika { get; set; }
        [Display(Name ="Datum odkritja")]
        public Nullable<System.DateTime> DijIDNadDatum { get; set; }
        [Display(Name ="Ustanova")]
        public string DijIDNadUstanova { get; set; }
        [Display(Name ="Potrditev")]
        public Nullable<System.DateTime> DijIDNadPotrditev { get; set; }
        [Display(Name ="Mati")]
        public string DijMati { get; set; }
        [Display(Name ="Oče")]

        public string DijOče { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
    
        public virtual Razredniki Razredniki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DijakPodročje> DijakPodročje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IzvedbaDijak> IzvedbaDijak { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanDijak> PlanDijak { get; set; }
    }
}

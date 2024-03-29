namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Materijal")]
    public partial class Materijal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materijal()
        {
            RadniNalog = new HashSet<RadniNalog>();
        }

        [Key]
        public int Materijal_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        public double CijenaMaterijala { get; set; }

        [Required]
        [StringLength(20)]
        public string JedinicaMjere { get; set; }

        public int Kolicina { get; set; }

        [StringLength(100)]
        public string Opis { get; set; }

        public bool? OpasnoPoZivot { get; set; }

        public string QR_kod { get; set; }

        public int? Primka_ID { get; set; }

        public int? Usluga_ID { get; set; }

        public virtual Primka Primka { get; set; }

        public virtual Usluga Usluga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RadniNalog> RadniNalog { get; set; }
    }
}

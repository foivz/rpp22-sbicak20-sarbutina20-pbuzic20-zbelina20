namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IzvjestajRadnihNaloga")]
    public partial class IzvjestajRadnihNaloga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IzvjestajRadnihNaloga()
        {
            RadniNalog = new HashSet<RadniNalog>();
        }

        [Key]
        public int IzvjestajRadnihNaloga_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        public DateTime? DatumStvaranja { get; set; }

        [Required]
        [StringLength(50)]
        public string Opis { get; set; }

        [Required]
        [StringLength(30)]
        public string Stvorio { get; set; }

        public int? Radnik_ID { get; set; }

        public virtual Radnik Radnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RadniNalog> RadniNalog { get; set; }
    }
}

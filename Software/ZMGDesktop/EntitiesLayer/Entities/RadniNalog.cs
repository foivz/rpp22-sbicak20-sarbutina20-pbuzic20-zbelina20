namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RadniNalog")]
    public partial class RadniNalog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RadniNalog()
        {
            IzvjestajRadnihNaloga = new HashSet<IzvjestajRadnihNaloga>();
            Materijal = new HashSet<Materijal>();
            Roba = new HashSet<Roba>();
        }

        [Key]
        public int RadniNalog_ID { get; set; }

        public int Kolicina { get; set; }

        [Required]
        [StringLength(100)]
        public string Opis { get; set; }

        [StringLength(150)]
        public string QR_kod { get; set; }

        public DateTime DatumStvaranja { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        public int? Radnik_ID { get; set; }

        public int? Klijent_ID { get; set; }

        public virtual Klijent Klijent { get; set; }

        public virtual Radnik Radnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IzvjestajRadnihNaloga> IzvjestajRadnihNaloga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materijal> Materijal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Roba> Roba { get; set; }
    }
}

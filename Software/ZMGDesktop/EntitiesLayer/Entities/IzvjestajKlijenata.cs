namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IzvjestajKlijenata")]
    public partial class IzvjestajKlijenata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IzvjestajKlijenata()
        {
            Klijent = new HashSet<Klijent>();
        }

        [Key]
        public int IzvjestajKlijenata_ID { get; set; }

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

        public int Radnik_ID { get; set; }

        public virtual Radnik Radnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Klijent> Klijent { get; set; }
    }
}

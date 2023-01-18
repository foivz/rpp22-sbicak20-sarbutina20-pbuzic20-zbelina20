namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Klijent")]
    public partial class Klijent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klijent()
        {
            Racun = new HashSet<Racun>();
            RadniNalog = new HashSet<RadniNalog>();
            Roba = new HashSet<Roba>();
        }

        [Key]
        public int Klijent_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(50)]
        public string Adresa { get; set; }

        [Required]
        [StringLength(50)]
        public string Mjesto { get; set; }

        [StringLength(11)]
        public string OIB { get; set; }

        [Required]
        [StringLength(10)]
        public string BrojTelefona { get; set; }

        [Required]
        [StringLength(60)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string IBAN { get; set; }

        public int? IzvjestajKlijenata_ID { get; set; }

        public virtual IzvjestajKlijenata IzvjestajKlijenata { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racun { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RadniNalog> RadniNalog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Roba> Roba { get; set; }
    }
}

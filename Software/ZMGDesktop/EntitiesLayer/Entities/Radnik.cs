namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Radnik")]
    public partial class Radnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Radnik()
        {
            IzvjestajKlijenata = new HashSet<IzvjestajKlijenata>();
            IzvjestajRadnihNaloga = new HashSet<IzvjestajRadnihNaloga>();
            Racun = new HashSet<Racun>();
            RadniNalog = new HashSet<RadniNalog>();
        }

        [Key]
        public int Radnik_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Ime { get; set; }

        [Required]
        [StringLength(20)]
        public string Prezime { get; set; }

        [Required]
        [StringLength(30)]
        public string Korime { get; set; }

        [Required]
        [StringLength(100)]
        public string Lozinka { get; set; }

        [StringLength(11)]
        public string OIB { get; set; }

        [StringLength(10)]
        public string BrojTelefona { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IzvjestajKlijenata> IzvjestajKlijenata { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IzvjestajRadnihNaloga> IzvjestajRadnihNaloga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racun { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RadniNalog> RadniNalog { get; set; }
    }
}

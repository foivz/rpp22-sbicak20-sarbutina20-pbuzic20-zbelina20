

namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Racun")]
    public partial class Racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Racun()
        {
            StavkaRacun = new HashSet<StavkaRacun>();
        }

        [Key]
        public int Racun_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Fakturirao { get; set; }

        [Required]
        [StringLength(100)]
        public string Opis { get; set; }

        [Required]
        [StringLength(50)]
        public string NacinPlacanja { get; set; }

        public double? UkupnaCijena { get; set; }

        public int? Klijent_ID { get; set; }

        public int? Radnik_ID { get; set; }

        public int? Poslodavac_ID { get; set; }

        public virtual Klijent Klijent { get; set; }

        public virtual Poslodavac Poslodavac { get; set; }

        public virtual Radnik Radnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StavkaRacun> StavkaRacun { get; set; }
    }
}

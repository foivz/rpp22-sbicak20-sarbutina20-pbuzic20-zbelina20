
namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Poslodavac")]
    public partial class Poslodavac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Poslodavac()
        {
            Racun = new HashSet<Racun>();
        }

        [Key]
        public int Poslodavac_ID { get; set; }

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

        [Required]
        [StringLength(50)]
        public string Banka { get; set; }

        [Required]
        [StringLength(20)]
        public string UpisObrtniRegistar { get; set; }

        [Required]
        [StringLength(30)]
        public string Poslovnica { get; set; }

        [Required]
        [StringLength(50)]
        public string Drzava { get; set; }

        [Required]
        [StringLength(30)]
        public string BrojObrtnice { get; set; }

        [Required]
        [StringLength(30)]
        public string TEL_FAX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racun { get; set; }
    }
}

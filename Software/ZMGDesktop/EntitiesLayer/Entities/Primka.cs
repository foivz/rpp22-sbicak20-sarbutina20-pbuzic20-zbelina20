namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Primka")]
    public partial class Primka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Primka()
        {
            Materijal = new HashSet<Materijal>();
        }

        [Key]
        public int Primka_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv_Materijal { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Datum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materijal> Materijal { get; set; }

        public int Kolicina { get; set; }
    }
}

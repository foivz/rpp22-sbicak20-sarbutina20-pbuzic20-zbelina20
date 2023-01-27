namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("StavkaRacun")]
    public partial class StavkaRacun
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Roba_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Usluga_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Racun_ID { get; set; }

        public int KolicinaRobe { get; set; }

        [Required]
        [StringLength(10)]
        public string JedinicaMjere { get; set; }

        public double UkupnaCijenaStavke { get; set; }

        public int KolikoRobePoJedinici { get; set; }

        public double JedinicnaCijena { get; set; }

        public DateTime? DatumIzrade { get; set; }

        public int KolikoRobePoJedinici { get; set; }

        public virtual Racun Racun { get; set; }

        public virtual Roba Roba { get; set; }

        public virtual Usluga Usluga { get; set; }
    }
}

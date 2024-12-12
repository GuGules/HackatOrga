using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackatOrga.models;

namespace HackatOrga.models
{
    [Table("hackathon")]
    public class Hackathon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int hackathonId { get; set; }
        public string nom { get; set; }
        [Column("date_debut")]
        public DateTime dateDeb { get; set; }
        [Column("date_limite_reg")]
        public DateTime dateLim { get; set; }
        [Column("date_fin")]
        public DateTime dateFin { get; set; }
        [Column("nb_places")]
        public decimal nbPlaces { get; set; }
        [ForeignKey("hackathonId")]
        public ICollection<Inscription> Inscriptions { get; set; }
        [ForeignKey("hackathonId")]
         public ICollection<Evenement> evenements { get; set; }
    }
}

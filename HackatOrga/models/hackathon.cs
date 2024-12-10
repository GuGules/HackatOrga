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
        public DateTime dateDeb { get; set; }
        public DateTime dateLim { get; set; }
        public DateTime dateFin { get; set; }
        public decimal nbPlaces { get; set; }
        [ForeignKey("hackathonId")]
        public List<Inscription>? Inscriptions { get; set; }
        [ForeignKey("hackathonId")]
         public ICollection<Evenement> evenements { get; set; }
    }
}

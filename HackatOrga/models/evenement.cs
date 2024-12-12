using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackatOrga.models;

namespace HackatOrga.models
{
    [Table("evenement")]
    public abstract class Evenement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int evenementId { get; set; }
        public string nom { get; set; }
        public DateTime date { get; set; }
        public TimeOnly duree { get; set; }
        public string salle { get; set; }
        [ForeignKey(nameof(Hackathon))]
        [Column("idHackathon")]
        public int hackathonId { get; set; }
        public virtual Hackathon Hackathon { get; set; }
    }

    public class Atelier : Evenement
    {
        [Column("nb_places")]
        public int nbPlaces { get; set; }
        [ForeignKey("evenementId")]
        public ICollection<ParticipantAtelier> ParticipantAteliers { get; set; }
    }

    public class Conf : Evenement 
    {
        public string intervenant { get; set; }
        public string theme { get; set; }
    }
}

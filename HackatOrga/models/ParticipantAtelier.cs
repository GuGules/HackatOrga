using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackatOrga.models;

namespace HackatOrga.models
{
    [Table("participantAtelier")]
    public class ParticipantAtelier
    {
        public int participantAtelierId {  get; set; }
        public string nom {  get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        [ForeignKey(nameof(Evenement))] /// clé étrangère
        public int evenementId { get; set; }
        public virtual Evenement Evenement { get; set; }
    }
}

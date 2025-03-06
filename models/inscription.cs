using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using HackatOrga.models;

namespace HackatOrga.models
{
    [Table("inscription")]
    public class Inscription
    {
        public int inscriptionId {  get; set; }
        public DateTime date_Saisie { get; set; }
        [ForeignKey(nameof(Hackathon))] /// clé étrangère
        public int hackathonId { get; set; }
        public virtual Hackathon Hackathon { get; set; }
        [ForeignKey(nameof(Participant))] /// clé étrangère
        public int participantId { get; set; }
        public virtual Participant Participant { get; set; }
    }
}

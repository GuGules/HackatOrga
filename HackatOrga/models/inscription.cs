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
    [PrimaryKey(nameof(hackathonId), nameof(participantId))]

    public class Inscription
    {
        public int hackathonId { get; set; }
        public int participantId { get; set; }
        public DateTime date_Saisie { get; set; }
        public Hackathon Hackathon { get; set; }
        public Participant Participant { get; set; }
    }
}

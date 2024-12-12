using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackatOrga.models;

namespace HackatOrga.models
{
    [Table("participant")]
    public class Participant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int participantId {  get; set; }
        public string nom {  get; set; }
        public string prenom {  get; set; }
        public string mail {  get; set; }
        public DateTime date_naissance {  get; set; }
        public string urlportfolio { get; set; }

        [ForeignKey("participantId")]
        public List<Inscription> Inscriptions { get; set; }
     }
}

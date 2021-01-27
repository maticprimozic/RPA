using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCStudent.Models
{
    public class Mentor
    {
        public int MentorId { get; set; }
        
        public string Ime { get; set; }
        [Required]
        public string Priimek { get; set; }
        [Display(Name ="Datum zaposlitve")]
        public DateTime DatumZaposlitve { get; set; }
        public bool Aktiven { get; set; }
    }
}
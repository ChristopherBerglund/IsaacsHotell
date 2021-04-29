using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IsaacsHotell.Models
{
    public class Gäst
    {
        public int Id { get; set; }
        [Required]
        public string Förnamn { get; set; }
        [Required]
        public string Efternamn { get; set; }
        [ForeignKey("FK_Bokning")]
        public int? BokningId { get; set; }
        public List<Bokning> Bokningar { get; set; }
        [ForeignKey("FK_Order")]
        public int? OrderId { get; set; }
        public Order Order{ get; set; }

    }
}

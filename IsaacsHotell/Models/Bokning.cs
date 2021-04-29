using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IsaacsHotell.Models
{
    public class Bokning // kan vara att en gäster ska kunna ha många bokningar, but i dunno
    {
        public int Id { get; set; }
        [Required]
        public DateTime Incheckning { get; set; }
        [Required]
        public DateTime Utcheckning { get; set; }
        [ForeignKey("FK_Gäst")]
        public int GästId { get; set; }
        public Gäst Gäst { get; set; }
        [ForeignKey("FK_Rum")]
        public int RumId { get; set; }
        public Rum Rum { get; set; }
        public bool ExtraSäng { get; set; }

        static int Kollarledigaplatser()//??kanske nått att ha 
        {
            return 1;
        }
    }
}

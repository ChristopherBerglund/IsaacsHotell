using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IsaacsHotell.Models
{
    public class StädRapport
    {
        public int ID { get; set; }

        public bool Rumettsmutigt { get; set; }
        public bool Rumtvåsmutigt { get; set; }
        public bool Rumtresmutigt { get; set; }
        public bool Rumfyresmutigt { get; set; }
        public bool Rumfemsmutigt { get; set; }
        public bool Rumsexsmutigt { get; set; }
        public bool Rumsjusmutigt { get; set; }
        public bool Rumåttasmutigt { get; set; }
        public bool Rumniomutigt { get; set; }
        public bool Rumtiomutigt { get; set; }

    }


    // söker på rum och ändrar bool till sant


    //          public bool ÄrStädat { get; set; } // ska städas
    //public DateTime DatumFörStäd { get; set; }

    //[ForeignKey("FK_Rum")]
    //public int RumId { get; set; }
    //public Rum Rum { get; set; }
}

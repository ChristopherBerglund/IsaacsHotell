using IsaacsHotell.Data;
using IsaacsHotell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaacsHotell.Method
{
    public class TotalPris
    {
        public static double Summera(List<Order> ordrar)
        {
            var totalsumma = 0.00;

            foreach (var order in ordrar)
            {
                if (order.Pris > 0)
                {
                    totalsumma += order.Pris;
                }
                else
                {
                    return -1;
                }
            }


            return totalsumma;
        }
    }

  
}

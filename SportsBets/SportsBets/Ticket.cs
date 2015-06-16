using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    class Ticket
    {
        public Game natprevar { get; set; }
        public int tip { get; set; }

        public Ticket()
        {
        }
        public Ticket(Game g, int t)
        {
            tip = 0;
            natprevar = g;
            tip = t;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1} - {2} {3:0.00}",natprevar.kod,natprevar.domasen.ime,natprevar.gostin.ime,natprevar.koef[tip]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    class Team
    {
        public string ime { get; set; }
        public string drzava { get; set; }

        public Team()
        {
        }
        public Team(string i, string d)
        {
            ime = i;
            drzava = d;
        }
        public override string ToString()
        {
            return ime + " - " + drzava;
        }
    }
}

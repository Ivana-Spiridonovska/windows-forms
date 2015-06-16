using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    class Game
    {
        public int kod { get; set; }
        public Team domasen { get; set; }
        public Team gostin { get; set; }
        public float []koef {get; set;} 

        public Game()
        {
            kod = 0;
        }
        public Game(int k, Team d, Team g, float e, float x, float dva)
        {
            koef = new float[3];
            kod = k;
            domasen = d;
            gostin = g;
            koef[0] = e;
            koef[1] = x;
            koef[2] = dva;
        }
        public override string ToString()
        {
            return String.Format("{0} : {1} - {2} {3:0.00} - {4:0.00} - {5:0.00}",kod, domasen.ime,gostin.ime,koef[0],koef[1],koef[2]);
        }
    }
}

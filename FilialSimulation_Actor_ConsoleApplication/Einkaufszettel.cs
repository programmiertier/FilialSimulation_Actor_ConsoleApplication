using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    internal class Einkaufszettel
    {
        struct zeile
        {
            public int artikel;
            public int anzahl;
        }

        static private List<zeile> _liste;

        public Einkaufszettel()
        {
            for (int von = 1; von <= 3; von++)
            {
                _liste.Add(new Einkaufszettel.zeile() { artikel = von, anzahl = von});
                WriteLine("Artikel {0} bitte {0} kaufen", von);
            }
        }


        /* public void zettel(int von, int bis)
        {
            for (von = 1; von <= bis; von++)
            {
                WriteLine("Artikel {0} bitte {0} mal einkaufen", von);
            }
        } */

        internal Actor Actor
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}

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
        public struct zeile
        {
            public int artikel;
            public int anzahl;
        }

        public List<zeile> liste = new List<zeile>();

        public Einkaufszettel()
        {
            for (int von = 1; von <= 3; von++)
            {
                liste.Add(new Einkaufszettel.zeile() { artikel = von, anzahl = von });
            }
        }

        public void zeigen()
        {
            foreach (zeile platzhalter in liste)
            {
                WriteLine("Artikel Nummer {0} ist {1} mal auf der Liste", platzhalter.artikel, platzhalter.anzahl);
            }
        }
        /* public void zettel(int von, int bis)
        {
            for (von = 1; von <= bis; von++)
            {
                WriteLine("Artikel {0} bitte {0} mal einkaufen", von);
            }
        } */
    }
}

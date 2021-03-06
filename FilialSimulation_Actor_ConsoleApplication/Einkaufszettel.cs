﻿using System;
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
            Random zufall = new Random(Actor.lfrNr);
            int bis = zufall.Next(1, 10);
            for (int von = 1; von <= bis; von++)
            { liste.Add(new zeile() { artikel = zufall.Next(1, 800), anzahl = zufall.Next(4, 10) }); }
        }

        public Einkaufszettel(string irgendwas)
        {

        }

        public void zeigen()
        {
            foreach (zeile platzhalter in liste)
            {
                WriteLine("Artikel Nummer {0} ist {1} mal auf der Liste", platzhalter.artikel, platzhalter.anzahl);
            }
        }
    }
}

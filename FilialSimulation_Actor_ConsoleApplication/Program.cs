﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Personal huber = new Personal();
            huber.listeAnzeigen();

            Dieb meier = new Dieb();
            meier.listeAnzeigen();

            Kunde becker = new Kunde();
            becker.listeAnzeigen();*/

            /* meinkleinereinkauf.zettel(1, 5);*/
            Kunde[] reisebus = new Kunde[30];
            for (int laenge = 0; laenge < reisebus.Length; laenge++)
            {
                reisebus[laenge] = new Kunde();
                reisebus[laenge].listeAnzeigen();
            }
            ReadLine();
        }
    }
}

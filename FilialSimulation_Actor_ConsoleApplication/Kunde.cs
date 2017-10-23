using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    internal class Kunde : Actor
    {
        public Kunde()
        {
            this.id = Actor.lfrNr;
            WriteLine("Ich bin ein Kunde und werde als {0}. aufgerufen", id);
        }

        ~Kunde()
        {
            WriteLine("Kunde wurde destruktiert");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    internal class Dieb : Kunde
    {
        public Dieb()
        {
            this.id = Actor.lfrNr;
            WriteLine("Ich bin ein Dieb und werde als {0}. aufgerufen", id);
        }
        ~Dieb()
        {
            WriteLine("Dieb wurde destruktiert");
        }

    }
}

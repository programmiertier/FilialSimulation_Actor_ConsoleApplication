using System;
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
            Dieb langfinger = new Dieb();
            langfinger.wareEntnehmen();

            Kunde huaba = new Kunde();
            huaba.wareEntnehmen();

            Personal herrmaier = new Personal();
            herrmaier.wareEntnehmen();

            ReadLine();
        }
    }
}

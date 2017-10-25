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
            /* Dieb huabasepp = new Dieb();
            huabasepp.bezahlen();

            Kunde marysophie = new Kunde();
            marysophie.bezahlen();

            Personal henno = new Personal();
            henno.bezahlen();

            Kunde klarairgendwas = new Kunde();
            klarairgendwas.bezahlen();

            Dieb paulchenpanter = new Dieb();
            paulchenpanter.bezahlen();

            Personal mariahubdi = new Personal();
            mariahubdi.bezahlen();  */

            Dieb irgendwer = new Dieb();
            irgendwer.wareEntnehmen();

            Kunde huaba = new Kunde();
            huaba.wareEntnehmen();

            ReadLine();
        }
    }
}

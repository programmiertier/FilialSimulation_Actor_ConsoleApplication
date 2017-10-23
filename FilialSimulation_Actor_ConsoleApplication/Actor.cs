using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FilialSimulation_Actor_ConsoleApplication
{
    internal class Actor
    {
        protected int id;
        private static int instances = 0;
        private string _rolle = "Actor";
        private Einkaufszettel _einkaufsliste;
        static public int lfrNr;


        // public Einkaufszettel Liste { get { _einkaufsliste; } set { _einkaufsliste = value; } }
        public Einkaufszettel einkaufsliste
        {
            get
            {
                return _einkaufsliste;
            }

            set
            {

            }
        }

        /* public Actor()
        {
            _einkaufsliste = new Einkaufszettel();
            instances++;
            _id = instances;
            if (this.GetType() == typeof(Kunde))
            {
                _rolle = "Kunde";
            }
            if (this.GetType() == typeof(Personal))
            {
                _rolle = "Personal";
            }
            if (this.GetType() == typeof(Dieb))
            {
                _rolle = "Dieb";
            }
        } */

        public Actor()
        {
            lfrNr++;
            _einkaufsliste = new Einkaufszettel();
            WriteLine("Zuerst geht es durch den leeren Konstruktor vom Actor");
        }

        ~Actor()
        {
            WriteLine("Actor wurde destruktiert");
        }

        public void listeAnzeigen()
        {
            // WriteLine("Person {0} hat die Rolle {1}", _id, _rolle);
            einkaufsliste.zeigen();
            ReadLine();
        }
    }
}

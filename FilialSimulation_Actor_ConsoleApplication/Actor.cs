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
        protected int _id;
        private static int instances = 0;
        protected string _rolle = "Actor";
        private Einkaufszettel _einkaufsliste;
        

        // public Einkaufszettel Liste { get { _einkaufsliste; } set { _einkaufsliste = value; } }


        public Actor()
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
        }

        public void listeAnzeigen()
        {
            WriteLine("Person {0} hat die Rolle {1}", _id, _rolle);
            _einkaufsliste.zeigen();
            ReadLine();
        }

        public int einkaufsliste
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

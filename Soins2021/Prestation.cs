using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2021
{
    class Prestation
    {

        //Attibuts

        private string libelle;
        private DateTime dateHeureSoin;
        private Intervenant intervenant;

        //Méthodes
        public Prestation(string libelle, DateTime dateHeureSoin,Intervenant intervenant)
        {
            this.libelle = libelle;
            if(DateTime.Compare(DateTime.Now.Date,dateHeureSoin.Date) >= 0 )
            {
                this.dateHeureSoin = dateHeureSoin;
            }
            this.intervenant = intervenant;
        }

        public override string ToString()
        {
            return "Libelle " + this.libelle + " - " + this.dateHeureSoin + " - " + this.intervenant + "\n\t";
        }
        public static int CompareTo(Prestation presta1, Prestation presta2)
        {
            return DateTime.Compare(presta1.dateHeureSoin.Date, presta2.dateHeureSoin.Date);
            
        }

        //Properties
        public string Libelle { get => libelle; }
        public DateTime DateHeureSoin { get => dateHeureSoin; }
        internal Intervenant Intervenant { get => intervenant; }
    }
}

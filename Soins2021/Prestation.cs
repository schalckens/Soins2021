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
        public Prestation(string libelle, string dateHeureSoin)
        {
            this.libelle = libelle;
            this.dateHeureSoin = dateHeureSoin;
        }
        public void CompareTo(Prestation presta1, Prestation presta2)
        {

        }

        //Properties
        public string Libelle { get => libelle; }
        public string DateHeureSoin { get => dateHeureSoin; }
    }
}

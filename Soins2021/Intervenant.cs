using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2021
{
    class Intervenant
    {

        //Attibuts

        private string nom;
        private string prenom;

        //Méthodes
        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public void AjoutePrestation()
        {

        }

        //Properties
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }

    }
}

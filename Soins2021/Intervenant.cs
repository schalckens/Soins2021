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
        private List<Prestation> prestations = new List<Prestation>();

        //Méthodes
        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public override string ToString()
        {
            return "Intervenant : " + this.nom + " - " + this.prenom;
        }
        public void AjoutePrestation(Prestation prestation)
        {
            prestations.Add(prestation);
        }

        //Properties
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }

    }
}

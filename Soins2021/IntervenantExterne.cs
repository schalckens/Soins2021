using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2021
{
    class IntervenantExterne : Intervenant
    {
        //Attributs

        private string specialite;
        private string adresse;
        private string tel;

        //Méthodes

        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel) : base(nom, prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        public override string ToString()
        {
            return base.ToString() + " Spécialité : " + this.specialite + " - " + this.adresse + " - " + this.tel;
        }

        //Properties
        public string Specialite { get => specialite; set => specialite = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}

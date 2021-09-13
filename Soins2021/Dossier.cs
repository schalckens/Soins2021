using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2021
{
    class Dossier
    {
        //Attributs

        private string nom;
        private string prenom;
        private string dateNaissance;
        private List<Prestation> prestations;

        //Méthodes
        public Dossier(string nom, string prenom, string dateNaissance)
        {
            
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.prestations = new List<Prestation>();
        }
        public Dossier(string nom, string prenom, string dateNaissance, Prestation prestation) :this(nom,prenom,dateNaissance)
        {
            AjoutePrestation(prestation.Libelle, prestation.DateHeureSoin);
        }
        public Dossier(string nom, string prenom, string dateNaissance, List<Prestation> prestations) :this(nom,prenom,dateNaissance)
        {
            this.prestations = prestations;
        }
        public void AjoutePrestation(string libelle,string dateHeureSoin)
        {
            this.prestations.Add(new Prestation(libelle, dateHeureSoin));
        }

        public void GetNbPrestationsExternes()
        {

        }

        public int GetNbPrestations()
        {
            return prestations.Count;
        }

        public void GetNbJoursSoins()
        {

        }

        //Properties
        public string Nom { get => nom;}
        public string Prenom { get => prenom;}
        public string DateNaissance { get => dateNaissance;}
    }
}

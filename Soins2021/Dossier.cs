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
        public Dossier(string nom, string prenom, string dateNaissance, Prestation prestation, Intervenant intervenant) :this(nom,prenom,dateNaissance)
        {
            AjoutePrestation(prestation.Libelle, prestation.DateHeureSoin, intervenant);
        }
        public Dossier(string nom, string prenom, string dateNaissance, List<Prestation> prestations) :this(nom,prenom,dateNaissance)
        {
            this.prestations = prestations;
        }
        public override string ToString()
        {
            string contenu = "";
            foreach(Prestation presta in prestations)
            {
                contenu += presta.ToString();
            }
            return "Nom : "+ this.nom + " Prenom : " + this.prenom + " Date de naissance : " + this.dateNaissance + "\n\t" + contenu;
        }
        public void AjoutePrestation(string libelle,DateTime dateHeureSoin, Intervenant intervenant)
        {
            this.prestations.Add(new Prestation(libelle, dateHeureSoin,intervenant));
        }

        public int GetNbPrestationsExternes()
        {
            int cpt = 0;
            foreach(Prestation prestation in prestations)
            {
                if (prestation.Intervenant is IntervenantExterne)
                {
                    cpt++;
                }
            }

            return cpt;
        }

        public int GetNbPrestations()
        {
            return prestations.Count;
        }

        public int GetNbJoursSoinsV1()
        {
            int nb = this.prestations.Count;
            for(int i = 0; i < this.prestations.Count-1; i++)
            {
                for(int j = i+1; j< this.prestations.Count; j++)
                {
                    if(this.prestations[i].DateHeureSoin.Date == this.prestations[j].DateHeureSoin.Date)
                    {
                        nb--;
                    }
                }
            }
            return nb;
        }
        public int GetNbJoursSoinsV2()
        {
            int nb = this.prestations.Count;
            for (int i = 0; i < this.prestations.Count - 1; i++)
            {
                for (int j = i + 1; j < this.prestations.Count; j++)
                {
                    if (Prestation.CompareTo(this.prestations[i],this.prestations[j]) == 0)
                    {
                        nb--;
                    }
                }
            }
            return nb;
        }

        //Properties
        public string Nom { get => nom;}
        public string Prenom { get => prenom;}
        public string DateNaissance { get => dateNaissance;}
    }
}

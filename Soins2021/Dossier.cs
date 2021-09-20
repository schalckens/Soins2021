using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Soins2021
{
    class Dossier
    {
        //Attributs

        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private List<Prestation> prestations;
        private DateTime dateCreation;

        //Méthodes
        public Dossier(string nom, string prenom, DateTime dateNaissance)
        {
            
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            //this.dateCreation = DateTime.Now;
            this.dateCreation = new DateTime(2015, 10, 8, 12, 00, 00);
            this.prestations = new List<Prestation>();
        }
        public Dossier(string nom, string prenom, DateTime dateNaissance, Prestation prestation) :this(nom,prenom,dateNaissance)
        {
            AjoutePrestation(prestation);
        }
        public Dossier(string nom, string prenom, DateTime dateNaissance, List<Prestation> prestations) :this(nom,prenom,dateNaissance)
        {
            foreach(Prestation prestation in prestations)
            {
                AjoutePrestation(prestation);
            }
        }
        public override string ToString()
        {
            string contenu = "";
            foreach(Prestation presta in prestations)
            {
                contenu += presta;
            }
            return "-------------Début dossier ------------ \n" + "Nom : "+ this.nom + " Prenom : " + this.prenom + " Date de naissance : " + this.dateNaissance + "\n\t" + contenu + "\n -------------Fin dossier --------------";
        }
        public void AjoutePrestation(Prestation prestation)
        {
            if(!(prestation.DateHeureSoin.CompareTo(dateCreation) == -1))
            {
                this.prestations.Add(prestation);
            }
            else
            {
                throw new SoinException("Date non-valide");
            }
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

        /// <summary>
        /// Première méthode pour obtenir le nb de jours de prestation.
        /// Méthode double boucle.
        /// </summary>
        /// <returns> nb jour soins </returns>
        public int GetNbJoursSoinsV1()
        {
            int nb = this.prestations.Count;
            for (int i = 0; i < this.prestations.Count - 1; i++)
            {
                for (int j = i + 1; j < this.prestations.Count; j++)
                {
                    if (Prestation.CompareTo(this.prestations[i], this.prestations[j]) == 0)
                    {
                        nb--;
                    }
                }
            }
            return nb;
        }

        /// <summary>
        /// Deuxième méthode pour obtenir le nb de jours de prestation.
        /// Ajout dans une liste viste si pas déjà présente.
        /// </summary>
        /// <returns> nb jour soins </returns>
        public int GetNbJoursSoinsV2()
        {
            List<DateTime> dates = new List<DateTime>();
            foreach(Prestation presta in prestations)
            {
                if (!dates.Contains(presta.DateHeureSoin.Date))
                {
                    dates.Add(presta.DateHeureSoin.Date);
                }
            }
            return dates.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetNbJoursSoinsV3()
        {
            List<Prestation> dateTrie = prestations.OrderBy(prest => prest.DateHeureSoin).ToList(); //ordre croissant
            //List<Prestation> dateTrie = prestations.OrderByDescending(prest => prest.DateHeureSoin).ToList(); //ordre décroissant

            DateTime baser = dateTrie[0].DateHeureSoin.Date;
            int cpt = 0;

            foreach (Prestation date in dateTrie)
            {
                if (!(date.DateHeureSoin.Date == baser))
                {
                    cpt++;
                    baser = date.DateHeureSoin.Date;
                }
            }

            return cpt+1;
        }

        private bool IsDateValide(DateTime date)
        {
            return true;
        }

        //Properties
        public string Nom { get => nom;}
        public string Prenom { get => prenom;}
        public DateTime DateNaissance { get => dateNaissance;}
        internal List<Prestation> Prestations { get => prestations; }
        public DateTime DateCreation { get => dateCreation; }
    }
}

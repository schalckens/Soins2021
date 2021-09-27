using Soins2021.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2021
{
    static class Traitement
    {
        // Traitement Bonus TP1

        internal static void TesteDossierTrieDatePrestation()
        {
            Dossier unDossier = new Dossier("Robert", "Jean", new DateTime(1980, 12, 3));

            // Les prestations sont triées par 
            Prestation prestation1 = new Prestation("Libelle P1", new DateTime(2015, 9, 1, 12, 0, 0), new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202"));
            unDossier.AjoutePrestation(prestation1);

            Prestation prestation2 = new Prestation("Libelle P2", new DateTime(2015, 9, 8, 12, 50, 0), new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303"));
            unDossier.AjoutePrestation(prestation2);

            Prestation prestation3 = new Prestation("Libelle P6", new DateTime(2015, 9, 8, 14, 30, 0), new Intervenant("Blanchard", "Michel"));
            unDossier.AjoutePrestation(prestation3);

            Prestation prestation4 = new Prestation("Libelle P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            unDossier.AjoutePrestation(prestation4);

            Prestation prestation5 = new Prestation("Libelle P5", new DateTime(2015, 9, 10, 16, 30, 0), new Intervenant("Tournier", "Hélène"));
            unDossier.AjoutePrestation(prestation5);

            Prestation prestation6 = new Prestation("Libelle P4", new DateTime(2015, 9, 20, 12, 0, 0), new Intervenant("Maurin", "Joëlle"));
            unDossier.AjoutePrestation(prestation6);
        }

        public static int GetNbJoursPresta(Dossier unDossier)
        {
            DateTime baser = unDossier.Prestations[0].DateHeureSoin.Date;
            int cpt = 0;

            foreach (Prestation presta in unDossier.Prestations)
            {
                if (!(presta.DateHeureSoin.Date == baser))
                {
                    cpt++;
                    baser = presta.DateHeureSoin.Date;
                }
            }

            return cpt + 1;
        }

        // Traitement TP2

        public static void TesteDossier()
        {
            Intervenant intervenant1 = new Intervenant("Dupont", "Jean");
            IntervenantExterne intervenant2 = new IntervenantExterne("Durant", "Annie", "Cardiologue", "Marseille", "0202020202");
            IntervenantExterne intervenant3 = new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "030303030");
            Intervenant intervenant4 = new Intervenant("Maurin", "Joelle");
            Intervenant intervenant5 = new Intervenant("Blanchard", "Michel");
            Intervenant intervenant6 = new Intervenant("Tournier", "Helene");

            Prestation prestation1 = new Prestation("P3", Convert.ToDateTime("10/09/2015 12:00:00"), intervenant1);
            Prestation prestation2 = new Prestation("P1", Convert.ToDateTime("01/09/2015 12:00:00"), intervenant2);
            Prestation prestation3 = new Prestation("P2", Convert.ToDateTime("08/09/2015 12:00:00"), intervenant3);
            Prestation prestation4 = new Prestation("P4", Convert.ToDateTime("20/09/2015 12:00:00"), intervenant4);
            Prestation prestation5 = new Prestation("P6", Convert.ToDateTime("08/09/2015 09:00:00"), intervenant5);
            Prestation prestation6 = new Prestation("P5", Convert.ToDateTime("10/09/2015 06:00:00"), intervenant6);

            List<Prestation> prestations = new List<Prestation>();
            prestations.Add(prestation1);
            prestations.Add(prestation2);
            prestations.Add(prestation3);
            prestations.Add(prestation4);
            prestations.Add(prestation5);
            prestations.Add(prestation6);

            Dossier dossier = new Dossier("Robert", "Jean", new DateTime(1980, 12, 3), prestations);

            Console.WriteLine(dossier);
        }

        public static void TesteGetNbPrestationsI()
        {
            Intervenant intervenant1 = new Intervenant("Dupont", "Jean");
            Prestation prestation1 = new Prestation("P3", Convert.ToDateTime("10/09/2015 12:00:00"), intervenant1);
            Prestation prestation2 = new Prestation("P1", Convert.ToDateTime("01/09/2015 12:00:00"), intervenant1);
            intervenant1.AjoutePrestation(prestation1);
            intervenant1.AjoutePrestation(prestation2);
            
            int nb = intervenant1.GetNbPrestations();
            Console.WriteLine("Nb Prestations Intervenant : " + nb);
        }
        public static void TesteGetNbPrestationsIE()
        {
            IntervenantExterne intervenant2 = new IntervenantExterne("Durant", "Annie", "Cardiologue", "Marseille", "0202020202");
            Prestation prestation3 = new Prestation("P2", Convert.ToDateTime("08/09/2015 12:00:00"), intervenant2);
            Prestation prestation4 = new Prestation("P4", Convert.ToDateTime("20/09/2015 12:00:00"), intervenant2);
            Prestation prestation5 = new Prestation("P6", Convert.ToDateTime("08/09/2015 09:00:00"), intervenant2);
            intervenant2.AjoutePrestation(prestation3);
            intervenant2.AjoutePrestation(prestation4);
            intervenant2.AjoutePrestation(prestation5);
            int nb = intervenant2.GetNbPrestations();
            Console.WriteLine("Nb Prestations Intervenant Externe :" + nb);
        }

        public static void TestDateDossierPrestationOK()
        {
            try
            {
                Intervenant intervenant1 = new Intervenant("Dupont", "Jean");
                IntervenantExterne intervenant2 = new IntervenantExterne("Durant", "Annie", "Cardiologue", "Marseille", "0202020202");
                IntervenantExterne intervenant3 = new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "030303030");
                Intervenant intervenant4 = new Intervenant("Maurin", "Joelle");
                Intervenant intervenant5 = new Intervenant("Blanchard", "Michel");
                Intervenant intervenant6 = new Intervenant("Tournier", "Helene");

                Prestation prestation1 = new Prestation("P3", Convert.ToDateTime("10/09/2015 12:00:00"), intervenant1);
                Prestation prestation2 = new Prestation("P1", Convert.ToDateTime("01/09/2015 12:00:00"), intervenant2);
                Prestation prestation3 = new Prestation("P2", Convert.ToDateTime("08/09/2015 12:00:00"), intervenant3);
                Prestation prestation4 = new Prestation("P4", Convert.ToDateTime("20/09/2015 12:00:00"), intervenant4);
                Prestation prestation5 = new Prestation("P6", Convert.ToDateTime("08/09/2015 09:00:00"), intervenant5);
                Prestation prestation6 = new Prestation("P5", Convert.ToDateTime("10/09/2015 06:00:00"), intervenant6);


                Dossier dossier = new Dossier("Robert", "Jean", new DateTime(1989, 12, 3), new DateTime(2013,09,15));
                dossier.AjoutePrestation(prestation1);
                dossier.AjoutePrestation(prestation2);
                dossier.AjoutePrestation(prestation3);
                dossier.AjoutePrestation(prestation4);
                dossier.AjoutePrestation(prestation5);
                dossier.AjoutePrestation(prestation6);

                Console.WriteLine("TestDateDossierPrestationOK : Succès");
            }
            catch (SoinException)
            {
                Console.WriteLine("TestDateDossierPrestationOK : Echec");
            }
            
        }
        public static void TestDateDossierPrestationKO()
        {
            try
            {
                Intervenant intervenant1 = new Intervenant("Dupont", "Jean");
                IntervenantExterne intervenant2 = new IntervenantExterne("Durant", "Annie", "Cardiologue", "Marseille", "0202020202");
                IntervenantExterne intervenant3 = new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "030303030");
                Intervenant intervenant4 = new Intervenant("Maurin", "Joelle");
                Intervenant intervenant5 = new Intervenant("Blanchard", "Michel");
                Intervenant intervenant6 = new Intervenant("Tournier", "Helene");

                Prestation prestation1 = new Prestation("P3", Convert.ToDateTime("10/09/2015 12:00:00"), intervenant1);
                Prestation prestation2 = new Prestation("P1", Convert.ToDateTime("01/09/2015 12:00:00"), intervenant2);
                Prestation prestation3 = new Prestation("P2", Convert.ToDateTime("08/09/2015 12:00:00"), intervenant3);
                Prestation prestation4 = new Prestation("P4", Convert.ToDateTime("20/09/2015 12:00:00"), intervenant4);
                Prestation prestation5 = new Prestation("P6", Convert.ToDateTime("08/09/2015 09:00:00"), intervenant5);
                Prestation prestation6 = new Prestation("P5", Convert.ToDateTime("10/09/2015 06:00:00"), intervenant6);


                Dossier dossier = new Dossier("Robert", "Jean", new DateTime(1989, 12, 3), new DateTime(2080, 12, 3));
                dossier.AjoutePrestation(prestation1);
                dossier.AjoutePrestation(prestation2);
                dossier.AjoutePrestation(prestation3);
                dossier.AjoutePrestation(prestation4);
                dossier.AjoutePrestation(prestation5);
                dossier.AjoutePrestation(prestation6);

                Console.WriteLine("TestDateDossierPrestationKO : Echec");
            }
            catch (SoinException)
            {
                Console.WriteLine("TestDateDossierPrestationKO : Succès");
            }

        }

        public static void TestDatePrestationOK()
        {
            try
            {
                Intervenant intervenant1 = new Intervenant("Dupont", "Jean");
                Prestation p = new Prestation("presta test", Convert.ToDateTime("10/09/2015 12:00:00"), intervenant1);

                Console.WriteLine("TestDatePrestationOK : Succès");
            }
            catch (Exception)
            {

                Console.WriteLine("TestDatePrestationOK : Echec");
            }
        }

        public static void TestDatePrestationKO()
        {
            try
            {
                Intervenant intervenant1 = new Intervenant("Dupont", "Jean");
                Prestation p = new Prestation("presta test", Convert.ToDateTime("10/09/2022 12:00:00"), intervenant1);

                Console.WriteLine("TestDatePrestationKO : Echec");
            }
            catch (Exception)
            {

                Console.WriteLine("TestDatePrestationKO : Succès");
            }
        }

        public static void TestDateDossierNaissanceOK()
        {
            try
            {
                Dossier d = new Dossier("Dupont", "Jean", Convert.ToDateTime("10/09/1989 12:00:00"));

                Console.WriteLine("TestDateDossierNaissanceOK : Succès");
            }
            catch (Exception)
            {

                Console.WriteLine("TestDateDossierNaissanceOK : Echec");
            }
        }
        public static void TestDateDossierNaissanceKO()
        {
            try
            {
                Dossier d = new Dossier("Dupont", "Jean", Convert.ToDateTime("10/09/2080 12:00:00"));

                Console.WriteLine("TestDateDossierNaissanceOK : Echec");
            }
            catch (Exception)
            {

                Console.WriteLine("TestDateDossierNaissanceOK : Succès");
            }
        }

        public static void TestDateDossierCreationOK()
        {
            try
            {
                Dossier d = new Dossier("Dupont", "Jean", Convert.ToDateTime("10/09/1989 12:00:00"), Convert.ToDateTime("10/09/2015 12:00:00"));

                Console.WriteLine("TestDateDossierCreationnOK : Succès");
            }
            catch (Exception)
            {

                Console.WriteLine("TestDateDossierCreationOK : Echec");
            }
        }
        public static void TestDateDossierCreationKO()
        {
            try
            {
                Dossier d = new Dossier("Dupont", "Jean", Convert.ToDateTime("10/09/1989 12:00:00"), Convert.ToDateTime("10/09/2080 12:00:00"));

                Console.WriteLine("TestDateDossierCreationOK : Echec");
            }
            catch (Exception)
            {

                Console.WriteLine("TestDateDossierCreationOK : Succès");
            }
        }
    }
}

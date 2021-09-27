using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2021
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Traitement.TesteDossier();
                //Traitement.TesteGetNbPrestationsI();
                //Traitement.TesteGetNbPrestationsIE();

                //Console.WriteLine("Nombre de jours de soins V1 :" + dossier.GetNbJoursSoinsV1());
                //Console.WriteLine("Nombre de jours de soins V2 :" + dossier.GetNbJoursSoinsV2());
                //Console.WriteLine("Nombre de jours de soins V3 :" + dossier.GetNbJoursSoinsV3());
                //Console.WriteLine("Nombre de soins externes : " + dossier.GetNbPrestationsExternes());

                //Traitement.TestDateDossierPrestationOK();
                //Traitement.TestDateDossierPrestationKO();
                //Traitement.TestDatePrestationOK();
                //Traitement.TestDatePrestationKO();
                Traitement.TestDateDossierCreationOK();
                Traitement.TestDateDossierCreationKO();
                Traitement.TestDateDossierNaissanceOK();
                Traitement.TestDateDossierNaissanceKO();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}

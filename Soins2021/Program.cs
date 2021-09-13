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
            Intervenant intervenant1 = new Intervenant("Dupont", "Jean");
            IntervenantExterne intervenant2 = new IntervenantExterne("Durant", "Annie", "Cardiologue","Marseille", "0202020202");
            IntervenantExterne intervenant3 = new IntervenantExterne("Sainz", "Olivier","Radiologue","Toulon","030303030");
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

            Dossier dossier = new Dossier("Robert", "Jean", "03/12/1980", prestations);

            Console.WriteLine("-------------Début dossier ------------");
            Console.WriteLine(dossier.ToString());
            Console.WriteLine("-------------Fin dossier --------------");
            Console.WriteLine("Nombre de jours de soins V1 :" + dossier.GetNbJoursSoinsV1());
            Console.WriteLine("Nombre de jours de soins V2 :" + dossier.GetNbJoursSoinsV2());
            Console.WriteLine("Nombre de soins externes : " + dossier.GetNbPrestationsExternes());

            Console.ReadKey();
        }
    }
}

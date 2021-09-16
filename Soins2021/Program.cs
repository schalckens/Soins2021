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

            Traitement.TesteDossier();
            Traitement.TesteGetNbPrestationsI();
            Traitement.TesteGetNbPrestationsIE();

            //Console.WriteLine("Nombre de jours de soins V1 :" + dossier.GetNbJoursSoinsV1());
            //Console.WriteLine("Nombre de jours de soins V2 :" + dossier.GetNbJoursSoinsV2());
            //Console.WriteLine("Nombre de jours de soins V3 :" + dossier.GetNbJoursSoinsV3());
            //Console.WriteLine("Nombre de soins externes : " + dossier.GetNbPrestationsExternes());

            DateTime une = new DateTime(2015, 10, 10, 12, 50, 00);
            DateTime de = new DateTime(2015, 10, 9, 12, 50, 00);

            Console.WriteLine(une + " et " + de);
            Console.WriteLine(une.CompareTo(de));

            Console.ReadKey();
        }
    }
}

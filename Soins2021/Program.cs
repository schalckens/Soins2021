using Newtonsoft.Json;
using Soins2021.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
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

                Traitement.TestDateDossierPrestationOK();
                Traitement.TestDateDossierPrestationKO();
                Traitement.TestDatePrestationOK();
                Traitement.TestDatePrestationKO();
                Traitement.TestDateDossierCreationOK();
                Traitement.TestDateDossierCreationKO();
                Traitement.TestDateDossierNaissanceOK();
                Traitement.TestDateDossierNaissanceKO();


                //string filePath = @"E:\Roche\TP C# 2a\Soins2021\Soins2021\ExceptionData.json";

                //FileStream file = new FileStream(@"E:\Roche\TP C# 2a\Soins2021\Soins2021\ExceptionData.json", FileMode.Append);
                //FileStream file = File.OpenWrite(filePath);
                //string jsonLog = JsonConvert.SerializeObject(SoinException.ListEx,Formatting.Indented);
                //File.AppendAllText(filePath, jsonLog);
                //byte[] bytes = Encoding.UTF8.GetBytes(jsonLog);
                //file.Write(bytes, 0, bytes.Length);

                SoinException.Log();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}

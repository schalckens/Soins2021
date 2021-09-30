using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Newtonsoft.Json;
using System.IO;

namespace Soins2021.Exceptions
{
    class SoinException : Exception
    { 
        private string message;
        private static string jsonLog;
        private static List<Dictionary<string,string>> listEx = new List<Dictionary<string, string>>();

        public SoinException(string message) :base(message) 
        {

            var log = new Dictionary<string, string>
            {
                {"Soins2021", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name.ToString()},
                {"ClasseException", GetType().Name.ToString()},
                {"DateException", DateTime.Now.ToString()},
                {"MessageException", this.Message},
                {"UserException", Environment.UserName},
                {"UserMachine", Environment.MachineName}
            };

            //TempException log = new TempException("SoinException", message, Environment.UserName.ToString(), Environment.MachineName.ToString());

            //SoinException.jsonLog = JsonConvert.SerializeObject(log,Formatting.Indented);

            //evo filestream

            listEx.Add(log);

            

            //string filePath = @"E:\Roche\TP C# 2a\Soins2021\Soins2021\ExceptionData.json";
            //File.AppendAllText(filePath, jsonLog);
        }
        public static void Log()
        {
            string logJson = JsonConvert.SerializeObject(SoinException.listEx, Formatting.Indented);
            string filePath = @"E:\Roche\TP C# 2a\Soins2021\Soins2021\ExceptionData.json";
            File.AppendAllText(filePath, logJson);
            string contenu = File.ReadAllText(filePath);
            contenu = contenu.Replace("][", string.Empty);
            File.WriteAllText(filePath, contenu);
        }

        public string Message1 { get => message; set => message = value; }
        public static List<Dictionary<string, string>> ListEx { get => listEx; set => listEx = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Newtonsoft.Json;


namespace Soins2021.Exceptions
{
    class SoinException : Exception
    { 
        private string message;
        private static string jsonLog;
        private static List<TempException> listEx;

        public SoinException(string message) :base(message) 
        {
            
            TempException log = new TempException("SoinException", message, Environment.UserName.ToString(), Environment.MachineName.ToString());

            SoinException.jsonLog =   JsonConvert.SerializeObject(log,Formatting.Indented);
            
            //evo filestream
        }
        public string Message1 { get => message; set => message = value; }
    }
}

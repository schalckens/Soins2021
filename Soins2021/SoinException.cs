using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2021.Exceptions
{
    class SoinException : Exception
    { 
        private string message;

        public SoinException(string message)
        {
            this.message = message;
        }

        public string Message1 { get => message; set => message = value; }
    }
}

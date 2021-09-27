using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2021.Exceptions
{
    internal class TempException
    {
        private string application;
        private string classeException;
        private DateTime dateException;
        private string messageException;
        private string userException;
        private string userMachine;

        public TempException(string classeException,string messageException, string userException, string userMachine)
        {
            this.Application = "Soins2021";
            this.ClasseException = classeException;
            this.DateException = DateTime.Now;
            this.messageException = messageException;
            this.userException = userException;
            this.userMachine = userMachine;
        }

        public string Application { get => application; set => application = value; }
        public string ClasseException { get => classeException; set => classeException = value; }
        public DateTime DateException { get => dateException; set => dateException = value; }
        public string MessageException { get => messageException; set => messageException = value; }
        public string UserException { get => userException; set => userException = value; }
        public string UserMachine { get => userMachine; set => userMachine = value; }
    }
}

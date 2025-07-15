using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica
{
    internal class Contatto
    {
        public string nome;
        public string cognome;
        public string telefono;
        public string email;

        public Contatto(string aName, string aCognome, string aTelefono, string aEmail) { 
            nome = aName;
            cognome = aCognome;
            telefono = aTelefono;  
            email = aEmail;
        }
    }

}

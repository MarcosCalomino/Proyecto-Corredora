using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Productor
   {
        private string nombreApellido;
        private string cuitProductor;
        private string password;
        public string NombreApellido { get => nombreApellido; set => nombreApellido = value; }
        public string CuitProductor { get => cuitProductor; set => cuitProductor = value; }
        public string Password { get => password; set => password = value; }

        public Productor(string nombreApellido, string cuitProductor, string password)
        {
            NombreApellido = nombreApellido;
            CuitProductor = cuitProductor;
            Password = password;
        }

        public Productor()
        {
           
        }      
   }
}

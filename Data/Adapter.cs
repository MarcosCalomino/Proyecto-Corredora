using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Adapter
    {   //C:/Users/Nuevo Usuario/Documents/Corredora/corredora1.accdb   path PC mia
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Nuevo Usuario\\Documents\\Corredora\\corredora1.accdb ;Persist Security Info=False;");

        public OleDbConnection Con { get => con; }
    }
}

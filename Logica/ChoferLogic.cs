using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ChoferLogic
    {
        public ChoferAdapter ChoferData { get; set; }
        public ChoferLogic()
        {
            ChoferData = new ChoferAdapter();
        }

        public List<Chofer> GetAll()
        {
            return ChoferData.GetAll();
        }

        public void AltaChofer(Chofer c)
        {
            ChoferData.AltaChofer(c);
        }

        public Chofer GetOne(int id)
        {
            return ChoferData.GetOne(id);
        }

        public void ModificarChofer(Chofer chofer, int id)
        {
            ChoferData.ModificarChofer(chofer, id);
        }
    }
}

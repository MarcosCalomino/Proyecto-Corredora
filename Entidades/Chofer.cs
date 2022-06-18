using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Chofer
    {
        private int id;
        private string cuitChofer;
        private string nombreApellidoChofer;
        private string nombreApellidoTransportista;
        private string cuitTransportista;
        private string cuitIntermediario;
        private string nombreApellidoIntermediario;
        private string patenteChasis;
        private string patenteAcoplado1;
        private string patenteAcoplado2;

        public string CuitChofer { get => cuitChofer; set => cuitChofer = value; }
        public string NombreApellidoChofer { get => nombreApellidoChofer; set => nombreApellidoChofer = value; }
        public string NombreApellidoTransportista { get => nombreApellidoTransportista; set => nombreApellidoTransportista = value; }
        public string CuitTransportista { get => cuitTransportista; set => cuitTransportista = value; }
        public string CuitIntermediario { get => cuitIntermediario; set => cuitIntermediario = value; }
        public string NombreApellidoIntermediario { get => nombreApellidoIntermediario; set => nombreApellidoIntermediario = value; }
        public string PatenteChasis { get => patenteChasis; set => patenteChasis = value; }
        public string PatenteAcoplado1 { get => patenteAcoplado1; set => patenteAcoplado1 = value; }
        public string PatenteAcoplado2 { get => patenteAcoplado2; set => patenteAcoplado2 = value; }
        public int Id { get => id; set => id = value; }
    }
}

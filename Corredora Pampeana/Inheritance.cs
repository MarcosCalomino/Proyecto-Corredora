using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corredora_Pampeana
{
    public partial class Inheritance : Form
    {
        public Inheritance()
        {
            InitializeComponent();
        }

        protected bool detectarFormularioAbierto(string formulario)
        {
            bool abierto = false;

            if (Application.OpenForms[formulario] != null)
            {
                abierto = true;
            }
            return abierto;
        }

        public virtual bool Validar()
        {
            return false;
        }

        public virtual void Listar()
        {

        }

        protected bool IsNumeric(string x)
        {
            if (Regex.IsMatch(x, @"^[0-9]+$"))
            {
                return true;
            }
            return false;
        }

        protected bool VerificaNombre(string n)
        {
            Regex name_validation = new Regex(@"^[\p{L} \.'\-]+$");

            if (name_validation.IsMatch(n))
            {
                return true;
            }
            return false;
        }

        protected bool VerificaPatente(string n)
        {
            Regex expression = new Regex(@"^([a-zA-Z]{3,3}[0-9]{3})+$");
            Regex expression2 = new Regex(@"^([a-zA-Z]{2}[0-9]{3}[a-zA-Z]{2})+$");
            if (expression.IsMatch(n) || expression2.IsMatch(n))
            {
                return true;
            }
            return false;
        }

        public virtual void Mapear()
        {

        }

       
    }
}

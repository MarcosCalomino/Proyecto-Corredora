using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corredora_Pampeana
{
    public partial class UpdateProductor : Inheritance
    {
        Productor Productor { get; set; }
        ProductorLogic ProductorLogic { get; set; }
        public UpdateProductor(string cuit)
        {
            InitializeComponent();
            ProductorLogic = new ProductorLogic();
            Productor = ProductorLogic.GetOne(cuit);
            this.txtOculto.Text = cuit;
            this.txtCuit.Text = Productor.CuitProductor;
            this.txtNombreApellido.Text = Productor.NombreApellido;
            this.txtPassword.Text = Productor.Password;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Productor = new Productor();
                Productor.CuitProductor = this.txtCuit.Text;
                Productor.NombreApellido = this.txtNombreApellido.Text.ToUpper();
                Productor.Password = this.txtPassword.Text;
                ProductorLogic.ModificarProductor(Productor, txtOculto.Text);
                MessageBox.Show("Modificado Correctamente");
                this.Close();
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrWhiteSpace(this.txtCuit.Text))
            {
                MessageBox.Show("Ingrese CUIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (this.txtCuit.Text.Length < 11 || this.txtCuit.Text.Length > 11)
            {
                MessageBox.Show("Cuit Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!IsNumeric(this.txtCuit.Text))
            {
                MessageBox.Show("Cuit Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(this.txtNombreApellido.Text) || this.txtNombreApellido.Text.Equals("Nombre y Apellido"))
            {
                MessageBox.Show("Ingrese Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!VerificaNombre(this.txtNombreApellido.Text))
            {
                MessageBox.Show("Nombre Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Password incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else return true;
        }
    }
}

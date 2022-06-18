using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Corredora_Pampeana
{
    public partial class NewProductor : Inheritance
    {
        public Productor ProductorActual { get; set; }
        public ProductorLogic ProductorLogic { get; set; }
        public NewProductor()
        {
            InitializeComponent();
            this.btnAgregar.Select();
        }

        private void txtCUIT_Leave(object sender, EventArgs e)
        {
            if (this.txtCUIT.Text == "")
            {
                txtCUIT.Text = "Ingrese CUIT";
                txtCUIT.ForeColor = Color.DimGray;
            }
        }

        private void txtCUIT_Enter(object sender, EventArgs e)
        {
            if (this.txtCUIT.Text == "Ingrese CUIT")
            {
                txtCUIT.Text = "";
                txtCUIT.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre y Apellido";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "Nombre y Apellido")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (this.txtApellido.Text == "")
            {
                txtApellido.Text = "Ingrese Apellido";
                txtApellido.ForeColor = Color.DimGray;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (this.txtApellido.Text == "Ingrese Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {
                txtPassword.Text = "Ingrese Password";
                txtPassword.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "Ingrese Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    ProductorActual = new Productor(this.txtNombre.Text.ToUpper(), this.txtCUIT.Text, this.txtPassword.Text);
                    ProductorLogic = new ProductorLogic();
                    ProductorLogic.AltaProductor(ProductorActual);
                    MessageBox.Show("Cargado Correctamente");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrWhiteSpace(this.txtCUIT.Text))
            {
                MessageBox.Show("Ingrese CUIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (this.txtCUIT.Text.Length < 11 || this.txtCUIT.Text.Length > 11)
            {
                MessageBox.Show("Cuit Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!IsNumeric(this.txtCUIT.Text))
            {
                MessageBox.Show("Cuit Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(this.txtNombre.Text) || this.txtNombre.Text.Equals("Nombre y Apellido"))
            {
                MessageBox.Show("Ingrese Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!VerificaNombre(this.txtNombre.Text))
            {
                MessageBox.Show("Nombre Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(this.txtPassword.Text) || this.txtPassword.Text.Equals("Password"))
            {
                MessageBox.Show("Password incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else return true;
        }
    }
}

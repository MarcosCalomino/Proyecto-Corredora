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
    public partial class NewChofer : Inheritance
    {
        public ChoferLogic ChoferLogic { get; set; }
        public Chofer Chofer { get; set; }
        public NewChofer()
        {
            InitializeComponent();
            this.btnAgregar.Select();
        }

        private void txtCUIT_Leave(object sender, EventArgs e)
        {
            if (this.txtCUIT.Text == "")
            {
                txtCUIT.Text = "CUIT Chofer";
                txtCUIT.ForeColor = Color.DimGray;
            }
        }

        private void txtCUIT_Enter(object sender, EventArgs e)
        {
            if (this.txtCUIT.Text == "CUIT Chofer")
            {
                txtCUIT.Text = "";
                txtCUIT.ForeColor = Color.Black;
            }
        }

        private void txtNombreApellidoChofer_Leave(object sender, EventArgs e)
        {
            if (this.txtNombreApellidoChofer.Text == "")
            {
                txtNombreApellidoChofer.Text = "Apellido y Nombre Chofer";
                txtNombreApellidoChofer.ForeColor = Color.DimGray;
            }
        }

        private void txtNombreApellidoChofer_Enter(object sender, EventArgs e)
        {
            if (this.txtNombreApellidoChofer.Text == "Apellido y Nombre Chofer")
            {
                txtNombreApellidoChofer.Text = "";
                txtNombreApellidoChofer.ForeColor = Color.Black;
            }
        }

        private void txtCuitTransportista_Leave(object sender, EventArgs e)
        {
            if (this.txtCuitTransportista.Text == "")
            {
                txtCuitTransportista.Text = "CUIT Transportista";
                txtCuitTransportista.ForeColor = Color.DimGray;
            }
        }

        private void txtCuitTransportista_Enter(object sender, EventArgs e)
        {
            if (this.txtCuitTransportista.Text == "CUIT Transportista")
            {
                txtCuitTransportista.Text = "";
                txtCuitTransportista.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                textBox1.Text = "Apellido y Nombre Transportista";
                textBox1.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Apellido y Nombre Transportista")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void txtCuitIntermediario_Leave(object sender, EventArgs e)
        {
            if (this.txtCuitIntermediario.Text == "")
            {
                txtCuitIntermediario.Text = "CUIT Intermediario";
                txtCuitIntermediario.ForeColor = Color.DimGray;
            }
        }

        private void txtCuitIntermediario_Enter(object sender, EventArgs e)
        {
            if (this.txtCuitIntermediario.Text == "CUIT Intermediario")
            {
                txtCuitIntermediario.Text = "";
                txtCuitIntermediario.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (this.txtNombreApellidoIntermediario.Text == "")
            {
                txtNombreApellidoIntermediario.Text = "Intermediario de flete";
                txtNombreApellidoIntermediario.ForeColor = Color.DimGray;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (this.txtNombreApellidoIntermediario.Text == "Intermediario de flete")
            {
                txtNombreApellidoIntermediario.Text = "";
                txtNombreApellidoIntermediario.ForeColor = Color.Black;
            }
        }

        private void txtPatenteChasis_Leave(object sender, EventArgs e)
        {
            if (this.txtPatenteChasis.Text == "")
            {
                txtPatenteChasis.Text = "Patente Chasis";
                txtPatenteChasis.ForeColor = Color.DimGray;
            }
        }

        private void txtPatenteChasis_Enter(object sender, EventArgs e)
        {
            if (this.txtPatenteChasis.Text == "Patente Chasis")
            {
                txtPatenteChasis.Text = "";
                txtPatenteChasis.ForeColor = Color.Black;
            }
        }

        private void txtPatenteAcoplado1_Leave(object sender, EventArgs e)
        {
            if (this.txtPatenteAcoplado1.Text == "")
            {
                txtPatenteAcoplado1.Text = "Patente Acoplado 1";
                txtPatenteAcoplado1.ForeColor = Color.DimGray;
            }
        }

        private void txtPatenteAcoplado1_Enter(object sender, EventArgs e)
        {
            if (this.txtPatenteAcoplado1.Text == "Patente Acoplado 1")
            {
                txtPatenteAcoplado1.Text = "";
                txtPatenteAcoplado1.ForeColor = Color.Black;
            }
        }

        private void txtPatenteAcoplado2_Leave(object sender, EventArgs e)
        {
            if (this.txtPatenteAcoplado2.Text == "")
            {
                txtPatenteAcoplado2.Text = "Patente Acoplado 2";
                txtPatenteAcoplado2.ForeColor = Color.DimGray;
            }
        }

        private void txtPatenteAcoplado2_Enter(object sender, EventArgs e)
        {
            if (this.txtPatenteAcoplado2.Text == "Patente Acoplado 2")
            {
                txtPatenteAcoplado2.Text = "";
                txtPatenteAcoplado2.ForeColor = Color.Black;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (ValidarCuitIntermediario() && ValidarNombreIntermediario())
                {
                    ChoferLogic = new ChoferLogic();
                    Mapear();
                    ChoferLogic.AltaChofer(Chofer);
                    MessageBox.Show("Cargado Correctamente");
                    this.Close();
                }

            }
        }

        public override void Mapear()
        {
            Chofer = new Chofer();
            Chofer.CuitChofer = this.txtCUIT.Text;
            Chofer.NombreApellidoChofer = this.txtNombreApellidoChofer.Text;
            Chofer.CuitTransportista = this.txtCuitTransportista.Text;
            Chofer.NombreApellidoTransportista = this.textBox1.Text;
            Chofer.PatenteChasis = this.txtPatenteChasis.Text;
            Chofer.PatenteAcoplado1 = this.txtPatenteAcoplado1.Text;
            if (this.txtCuitIntermediario.Text.Equals("CUIT Intermediario") || this.txtNombreApellidoIntermediario.Text.Equals("Intermediario de flete"))
            {
                Chofer.CuitIntermediario = "-";
                Chofer.NombreApellidoIntermediario = "-";
            }
            else
            {
                Chofer.CuitIntermediario = this.txtCuitIntermediario.Text;
                Chofer.NombreApellidoIntermediario = this.txtNombreApellidoIntermediario.Text;
            }

            if (string.IsNullOrEmpty(this.txtPatenteAcoplado2.Text) || this.txtPatenteAcoplado2.Text.Equals("Patente Acoplado 2"))
            {
                Chofer.PatenteAcoplado2 = "-";
            }
            else
            {
                Chofer.PatenteAcoplado2 = this.txtPatenteAcoplado2.Text;
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrWhiteSpace(this.txtCUIT.Text))
            {
                MessageBox.Show("Ingrese CUIT de chofer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (this.txtCUIT.Text.Length < 11 || this.txtCUIT.Text.Length > 11)
            {
                MessageBox.Show("Cuit de chofer Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!IsNumeric(this.txtCUIT.Text))
            {
                MessageBox.Show("Cuit de chofer Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(this.txtNombreApellidoChofer.Text) || this.txtNombreApellidoChofer.Text.Equals("Apellido y Nombre Chofer"))
            {
                MessageBox.Show("Ingrese Nombre y apellido de Chofer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!VerificaNombre(this.txtNombreApellidoChofer.Text))
            {
                MessageBox.Show("Nombre de chofer Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(this.txtCuitTransportista.Text))
            {
                MessageBox.Show("Ingrese CUIT de Transportista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (this.txtCuitTransportista.Text.Length < 11 || this.txtCuitTransportista.Text.Length > 11)
            {
                MessageBox.Show("Ingrese CUIT de Transportista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!IsNumeric(this.txtCuitTransportista.Text))
            {
                MessageBox.Show("Cuit transportista Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(this.textBox1.Text) || this.textBox1.Text.Equals("Apellido y Nombre Transportista"))
            {
                MessageBox.Show("Ingrese Nombre Transportista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!VerificaNombre(this.textBox1.Text))
            {
                MessageBox.Show("Nombre Transportista Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(this.txtPatenteChasis.Text))
            {
                MessageBox.Show("Ingrese Patente de Chasis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!VerificaPatente(this.txtPatenteChasis.Text))
            {
                MessageBox.Show("Patente Chasis incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtPatenteAcoplado1.Text))
            {
                MessageBox.Show("Ingrese Patente Acoplado 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!VerificaPatente(this.txtPatenteAcoplado1.Text))
            {
                MessageBox.Show("Patente Acoplado 1 Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (string.IsNullOrEmpty(this.txtPatenteAcoplado2.Text) || this.txtPatenteAcoplado2.Text.Equals("Patente Acoplado 2"))
            {
                return true;
            }
            else if (!VerificaPatente(this.txtPatenteAcoplado2.Text))
            {
                MessageBox.Show("Patente Acoplado 2 Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }       
        }

        public bool ValidarCuitIntermediario()
        {
            if (!this.txtCuitIntermediario.Text.Equals("CUIT Intermediario"))
            {
                if (string.IsNullOrEmpty(this.txtCuitIntermediario.Text))
                {
                    MessageBox.Show("CUIT intermediario de flete incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if ((this.txtCuitIntermediario.Text.Length < 11) || (this.txtCuitIntermediario.Text.Length > 11))
                {
                    MessageBox.Show("CUIT intermediario de flete incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (!IsNumeric(this.txtCuitIntermediario.Text))
                {
                    MessageBox.Show("CUIT intermediario de flete incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        public bool ValidarNombreIntermediario()
        {
            if (!this.txtNombreApellidoIntermediario.Text.Equals("Intermediario de flete"))
            {
                if (string.IsNullOrWhiteSpace(this.txtNombreApellidoIntermediario.Text))
                {
                    MessageBox.Show("Nombre Apellido Intermediario Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (!VerificaNombre(this.txtNombreApellidoIntermediario.Text))
                {
                    MessageBox.Show("Nombre Apellido Intermediario Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }               
            }
            return true;
        }
    }
    
}

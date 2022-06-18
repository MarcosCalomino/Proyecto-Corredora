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
    public partial class UpdateChofer : Inheritance
    {
        public Chofer Chofer { get; set; }
        public ChoferLogic ChoferLogic { get; set; }
        public UpdateChofer(int id)
        {
            InitializeComponent();
            ChoferLogic = new ChoferLogic();
            Chofer = ChoferLogic.GetOne(id);
            this.txtOculto.Text = Chofer.Id.ToString();
            this.txtCuitChofer.Text = Chofer.CuitChofer;
            this.txtNombreApellidoChofer.Text = Chofer.NombreApellidoChofer;
            this.txtCuitTransportista.Text = Chofer.CuitTransportista;
            this.txtNombreApellidoTransportista.Text = Chofer.NombreApellidoTransportista;
            this.txtCuitIntermediario.Text = Chofer.CuitIntermediario;
            this.txtNombreApellidoIntermediario.Text = Chofer.NombreApellidoIntermediario;
            this.txtPatenteChasis.Text = Chofer.PatenteChasis;
            this.txtPatenteAcoplado1.Text = Chofer.PatenteAcoplado1;
            this.txtPatenteAcoplado2.Text = Chofer.PatenteAcoplado2;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (ValidarCuitIntermediario() && ValidarNombreIntermediario())
                {
                    ChoferLogic = new ChoferLogic();
                    Chofer = new Chofer();
                    //Chofer.Id = Int32.Parse(this.txtOculto.Text);
                    Chofer.CuitChofer = this.txtCuitChofer.Text;
                    Chofer.NombreApellidoChofer = this.txtNombreApellidoChofer.Text;
                    Chofer.CuitTransportista = this.txtCuitTransportista.Text;
                    Chofer.NombreApellidoTransportista = this.txtNombreApellidoTransportista.Text;
                    Chofer.CuitIntermediario = this.txtCuitIntermediario.Text;
                    Chofer.NombreApellidoIntermediario = this.txtNombreApellidoIntermediario.Text;
                    Chofer.PatenteChasis = this.txtPatenteChasis.Text;
                    Chofer.PatenteAcoplado1 = this.txtPatenteAcoplado1.Text;
                    Chofer.PatenteAcoplado2 = this.txtPatenteAcoplado2.Text;
                    ChoferLogic.ModificarChofer(Chofer, Int32.Parse(this.txtOculto.Text));
                    MessageBox.Show("Modificado Correctamente");
                    this.Close();
                }

            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrWhiteSpace(this.txtCuitChofer.Text))
            {
                MessageBox.Show("Ingrese CUIT de chofer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (this.txtCuitChofer.Text.Length < 11 || this.txtCuitChofer.Text.Length > 11)
            {
                MessageBox.Show("Cuit de chofer Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!IsNumeric(this.txtCuitChofer.Text))
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
            else if (string.IsNullOrWhiteSpace(this.txtNombreApellidoTransportista.Text) || this.txtNombreApellidoTransportista.Text.Equals("Apellido y Nombre Transportista"))
            {
                MessageBox.Show("Ingrese Nombre Transportista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!VerificaNombre(this.txtNombreApellidoTransportista.Text))
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
            else if (string.IsNullOrEmpty(this.txtPatenteAcoplado2.Text) || this.txtPatenteAcoplado2.Text.Equals("Patente Acoplado 2") || this.txtPatenteAcoplado2.Text.Equals("-"))
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
            if (!this.txtCuitIntermediario.Text.Equals("CUIT Intermediario")  && !this.txtCuitIntermediario.Text.Equals("-"))
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
            if (!this.txtNombreApellidoIntermediario.Text.Equals("Intermediario de flete") && !this.txtNombreApellidoIntermediario.Text.Equals("-"))
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

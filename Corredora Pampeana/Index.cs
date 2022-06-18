using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corredora_Pampeana
{
    public partial class Index : Inheritance
    {
        public Index()
        {
            InitializeComponent();
            this.btnExaminar.Select();
        }

        private void txtNroCarta_Leave(object sender, EventArgs e)
        {
            if (this.txtNroCarta.Text == "")
            {
                txtNroCarta.Text = "Ingrese CTG";
                txtNroCarta.ForeColor = Color.DimGray;
            }
        }

        private void txtNroCarta_Enter(object sender, EventArgs e)
        {
            if (this.txtNroCarta.Text == "Ingrese CTG")
            {
                txtNroCarta.Text = "";
                txtNroCarta.ForeColor = Color.Black;
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtExaminar.Text = fbd.SelectedPath;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(this.txtExaminar.Text + "\\" + this.txtNroCarta.Text + ".pdf");
            }
            catch
            {
                MessageBox.Show("La carta no se encontró");
            }
        }

        private void productoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("Productores"))
            {
                Productores p = new Productores();
                p.Show();
            }
            else
            {                
                MessageBox.Show("EL FORMULARIO YA ESTA OPEN","form open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }
        }

        private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("Choferes"))
            {
                Choferes p = new Choferes();
                p.Show();
            }
            else
            {
                MessageBox.Show("EL FORMULARIO YA ESTA OPEN", "form open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

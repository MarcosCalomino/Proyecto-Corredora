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
    public partial class Choferes : Inheritance
    {
        public ChoferLogic ChoferLogic { get; set; }
        List<Chofer> listaChoferes;
        public Choferes()
        {
            InitializeComponent();
            ChoferLogic = new ChoferLogic();
            this.Listar();
        }

        public override void Listar()
        {
            listaChoferes = ChoferLogic.GetAll().OrderBy(chofer => chofer.NombreApellidoChofer).ToList();
            this.dataGridView1.DataSource = listaChoferes;
            //foreach (Chofer c in listaChoferes)
            //{
            //    this.txtChoferes.Text = string.Format("TRANSPORTISTA: {0} {1}\r\nCHOFER:                     {2} {3}\r\nCHASIS: {4}\r\t ACOPLADO 1: {5}\r\t ACOPLADO 2: {6}\r\nINT. DE FLETE: {7} {8}\r\n---------------------------------------------------------\r\n", 
            //                            c.CuitTransportista, c.NombreApellidoTransportista, c.CuitChofer, c.NombreApellidoChofer, c.PatenteChasis, c.PatenteAcoplado1, c.PatenteAcoplado2, c.CuitIntermediario, c.NombreApellidoIntermediario);
            //}
        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewChofer nc = new NewChofer();
            nc.ShowDialog();
            this.Listar();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                //string cuit = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                UpdateChofer ch = new UpdateChofer(id);
                ch.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

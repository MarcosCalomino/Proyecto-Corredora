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
    public partial class Productores : Inheritance
    {
        public ProductorLogic ProductorLogic { get; set; }
        public Productores()
        {
            InitializeComponent();          
            Listar();
        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!detectarFormularioAbierto("NewProductor"))
            {
                NewProductor np = new NewProductor();
                np.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("EL FORMULARIO YA ESTA OPEN", "form open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }        
        }

        public override void Listar()
        {
            ProductorLogic = new ProductorLogic();
            List<Productor> listaOrdenadaAlfabeticamente = ProductorLogic.GetAll().OrderBy(productor => productor.NombreApellido).ToList();
            this.dataGridView1.DataSource = listaOrdenadaAlfabeticamente;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string cuit = dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString();
                //string cuit = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                UpdateProductor up = new UpdateProductor(cuit);
                up.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


namespace Corredora_Pampeana
{
    partial class Choferes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choferes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CuitChofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuitTransportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatenteChasis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatenteAcoplado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatenteAcoplado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitIFletes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IFlete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CuitChofer,
            this.Chofer,
            this.CuitTransportista,
            this.Transportista,
            this.PatenteChasis,
            this.PatenteAcoplado1,
            this.PatenteAcoplado2,
            this.cuitIFletes,
            this.IFlete});
            this.dataGridView1.Location = new System.Drawing.Point(17, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(509, 462);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(426, 565);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 22);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Choferes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarNuevoToolStripMenuItem
            // 
            this.agregarNuevoToolStripMenuItem.Name = "agregarNuevoToolStripMenuItem";
            this.agregarNuevoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.agregarNuevoToolStripMenuItem.Text = "Agregar Nuevo";
            this.agregarNuevoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // CuitChofer
            // 
            this.CuitChofer.DataPropertyName = "CuitChofer";
            this.CuitChofer.HeaderText = "Cuit Chofer";
            this.CuitChofer.Name = "CuitChofer";
            this.CuitChofer.ReadOnly = true;
            // 
            // Chofer
            // 
            this.Chofer.DataPropertyName = "NombreApellidoChofer";
            this.Chofer.HeaderText = "Chofer";
            this.Chofer.Name = "Chofer";
            this.Chofer.ReadOnly = true;
            // 
            // CuitTransportista
            // 
            this.CuitTransportista.DataPropertyName = "CuitTransportista";
            this.CuitTransportista.HeaderText = "Cuit Transportista";
            this.CuitTransportista.Name = "CuitTransportista";
            this.CuitTransportista.ReadOnly = true;
            // 
            // Transportista
            // 
            this.Transportista.DataPropertyName = "NombreApellidoTransportista";
            this.Transportista.HeaderText = "Transportista";
            this.Transportista.Name = "Transportista";
            this.Transportista.ReadOnly = true;
            // 
            // PatenteChasis
            // 
            this.PatenteChasis.DataPropertyName = "PatenteChasis";
            this.PatenteChasis.HeaderText = "Patente Chasis";
            this.PatenteChasis.Name = "PatenteChasis";
            this.PatenteChasis.ReadOnly = true;
            // 
            // PatenteAcoplado1
            // 
            this.PatenteAcoplado1.DataPropertyName = "PatenteAcoplado1";
            this.PatenteAcoplado1.HeaderText = "Acoplado";
            this.PatenteAcoplado1.Name = "PatenteAcoplado1";
            this.PatenteAcoplado1.ReadOnly = true;
            // 
            // PatenteAcoplado2
            // 
            this.PatenteAcoplado2.DataPropertyName = "PatenteAcoplado2";
            this.PatenteAcoplado2.HeaderText = "Acoplado 2";
            this.PatenteAcoplado2.Name = "PatenteAcoplado2";
            this.PatenteAcoplado2.ReadOnly = true;
            // 
            // cuitIFletes
            // 
            this.cuitIFletes.DataPropertyName = "CuitIntermediario";
            this.cuitIFletes.HeaderText = "Cuit Int. de flete";
            this.cuitIFletes.Name = "cuitIFletes";
            this.cuitIFletes.ReadOnly = true;
            // 
            // IFlete
            // 
            this.IFlete.DataPropertyName = "NombreApellidoIntermediario";
            this.IFlete.HeaderText = "Intermediario de flete";
            this.IFlete.Name = "IFlete";
            this.IFlete.ReadOnly = true;
            // 
            // Choferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 590);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Choferes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choferes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuitChofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuitTransportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatenteChasis;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatenteAcoplado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatenteAcoplado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitIFletes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IFlete;
    }
}

namespace Corredora_Pampeana
{
    partial class NewChofer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewChofer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuitTransportista = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombreApellidoChofer = new System.Windows.Forms.TextBox();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPatenteChasis = new System.Windows.Forms.TextBox();
            this.txtPatenteAcoplado1 = new System.Windows.Forms.TextBox();
            this.txtPatenteAcoplado2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuitIntermediario = new System.Windows.Forms.TextBox();
            this.txtNombreApellidoIntermediario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Agregar Chofer";
            // 
            // txtCuitTransportista
            // 
            this.txtCuitTransportista.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCuitTransportista.Location = new System.Drawing.Point(5, 91);
            this.txtCuitTransportista.Name = "txtCuitTransportista";
            this.txtCuitTransportista.Size = new System.Drawing.Size(327, 20);
            this.txtCuitTransportista.TabIndex = 26;
            this.txtCuitTransportista.Text = "CUIT Transportista";
            this.txtCuitTransportista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCuitTransportista.Enter += new System.EventHandler(this.txtCuitTransportista_Enter);
            this.txtCuitTransportista.Leave += new System.EventHandler(this.txtCuitTransportista_Leave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(5, 308);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(328, 24);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombreApellidoChofer
            // 
            this.txtNombreApellidoChofer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreApellidoChofer.Location = new System.Drawing.Point(5, 65);
            this.txtNombreApellidoChofer.Name = "txtNombreApellidoChofer";
            this.txtNombreApellidoChofer.Size = new System.Drawing.Size(328, 20);
            this.txtNombreApellidoChofer.TabIndex = 24;
            this.txtNombreApellidoChofer.Text = "Apellido y Nombre Chofer";
            this.txtNombreApellidoChofer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreApellidoChofer.Enter += new System.EventHandler(this.txtNombreApellidoChofer_Enter);
            this.txtNombreApellidoChofer.Leave += new System.EventHandler(this.txtNombreApellidoChofer_Leave);
            // 
            // txtCUIT
            // 
            this.txtCUIT.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCUIT.Location = new System.Drawing.Point(5, 39);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(328, 20);
            this.txtCUIT.TabIndex = 23;
            this.txtCUIT.Text = "CUIT Chofer";
            this.txtCUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCUIT.Enter += new System.EventHandler(this.txtCUIT_Enter);
            this.txtCUIT.Leave += new System.EventHandler(this.txtCUIT_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(5, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "Apellido y Nombre Transportista";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtPatenteChasis
            // 
            this.txtPatenteChasis.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPatenteChasis.Location = new System.Drawing.Point(6, 223);
            this.txtPatenteChasis.Name = "txtPatenteChasis";
            this.txtPatenteChasis.Size = new System.Drawing.Size(173, 20);
            this.txtPatenteChasis.TabIndex = 29;
            this.txtPatenteChasis.Text = "Patente Chasis";
            this.txtPatenteChasis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPatenteChasis.Enter += new System.EventHandler(this.txtPatenteChasis_Enter);
            this.txtPatenteChasis.Leave += new System.EventHandler(this.txtPatenteChasis_Leave);
            // 
            // txtPatenteAcoplado1
            // 
            this.txtPatenteAcoplado1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPatenteAcoplado1.Location = new System.Drawing.Point(5, 249);
            this.txtPatenteAcoplado1.Name = "txtPatenteAcoplado1";
            this.txtPatenteAcoplado1.Size = new System.Drawing.Size(174, 20);
            this.txtPatenteAcoplado1.TabIndex = 30;
            this.txtPatenteAcoplado1.Text = "Patente Acoplado 1";
            this.txtPatenteAcoplado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPatenteAcoplado1.Enter += new System.EventHandler(this.txtPatenteAcoplado1_Enter);
            this.txtPatenteAcoplado1.Leave += new System.EventHandler(this.txtPatenteAcoplado1_Leave);
            // 
            // txtPatenteAcoplado2
            // 
            this.txtPatenteAcoplado2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPatenteAcoplado2.Location = new System.Drawing.Point(5, 275);
            this.txtPatenteAcoplado2.Name = "txtPatenteAcoplado2";
            this.txtPatenteAcoplado2.Size = new System.Drawing.Size(174, 20);
            this.txtPatenteAcoplado2.TabIndex = 31;
            this.txtPatenteAcoplado2.Text = "Patente Acoplado 2";
            this.txtPatenteAcoplado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPatenteAcoplado2.Enter += new System.EventHandler(this.txtPatenteAcoplado2_Enter);
            this.txtPatenteAcoplado2.Leave += new System.EventHandler(this.txtPatenteAcoplado2_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Camion";
            // 
            // txtCuitIntermediario
            // 
            this.txtCuitIntermediario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCuitIntermediario.Location = new System.Drawing.Point(5, 144);
            this.txtCuitIntermediario.Name = "txtCuitIntermediario";
            this.txtCuitIntermediario.Size = new System.Drawing.Size(327, 20);
            this.txtCuitIntermediario.TabIndex = 33;
            this.txtCuitIntermediario.Text = "CUIT Intermediario";
            this.txtCuitIntermediario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCuitIntermediario.Enter += new System.EventHandler(this.txtCuitIntermediario_Enter);
            this.txtCuitIntermediario.Leave += new System.EventHandler(this.txtCuitIntermediario_Leave);
            // 
            // txtNombreApellidoIntermediario
            // 
            this.txtNombreApellidoIntermediario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreApellidoIntermediario.Location = new System.Drawing.Point(5, 171);
            this.txtNombreApellidoIntermediario.Name = "txtNombreApellidoIntermediario";
            this.txtNombreApellidoIntermediario.Size = new System.Drawing.Size(327, 20);
            this.txtNombreApellidoIntermediario.TabIndex = 34;
            this.txtNombreApellidoIntermediario.Text = "Intermediario de flete";
            this.txtNombreApellidoIntermediario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreApellidoIntermediario.Enter += new System.EventHandler(this.textBox6_Enter);
            this.txtNombreApellidoIntermediario.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // NewChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 344);
            this.Controls.Add(this.txtNombreApellidoIntermediario);
            this.Controls.Add(this.txtCuitIntermediario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatenteAcoplado2);
            this.Controls.Add(this.txtPatenteAcoplado1);
            this.Controls.Add(this.txtPatenteChasis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuitTransportista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreApellidoChofer);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewChofer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Chofer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuitTransportista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreApellidoChofer;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPatenteChasis;
        private System.Windows.Forms.TextBox txtPatenteAcoplado1;
        private System.Windows.Forms.TextBox txtPatenteAcoplado2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuitIntermediario;
        private System.Windows.Forms.TextBox txtNombreApellidoIntermediario;
    }
}
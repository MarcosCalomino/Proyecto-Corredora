
namespace Corredora_Pampeana
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtExaminar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtNroCarta = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExaminar
            // 
            this.btnExaminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExaminar.Location = new System.Drawing.Point(437, 90);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 15;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtExaminar
            // 
            this.txtExaminar.ForeColor = System.Drawing.SystemColors.Info;
            this.txtExaminar.Location = new System.Drawing.Point(47, 92);
            this.txtExaminar.Name = "txtExaminar";
            this.txtExaminar.ReadOnly = true;
            this.txtExaminar.Size = new System.Drawing.Size(384, 20);
            this.txtExaminar.TabIndex = 14;
            this.txtExaminar.Text = "Seleccione carpeta en la cual buscar carta de porte";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAbrir.Location = new System.Drawing.Point(437, 118);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 12;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtNroCarta
            // 
            this.txtNroCarta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNroCarta.Location = new System.Drawing.Point(47, 121);
            this.txtNroCarta.Name = "txtNroCarta";
            this.txtNroCarta.Size = new System.Drawing.Size(384, 20);
            this.txtNroCarta.TabIndex = 11;
            this.txtNroCarta.Text = "Ingrese CTG";
            this.txtNroCarta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroCarta.Enter += new System.EventHandler(this.txtNroCarta_Enter);
            this.txtNroCarta.Leave += new System.EventHandler(this.txtNroCarta_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoresToolStripMenuItem,
            this.choferesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoresToolStripMenuItem
            // 
            this.productoresToolStripMenuItem.Name = "productoresToolStripMenuItem";
            this.productoresToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.productoresToolStripMenuItem.Text = "Productores";
            this.productoresToolStripMenuItem.Click += new System.EventHandler(this.productoresToolStripMenuItem_Click);
            // 
            // choferesToolStripMenuItem
            // 
            this.choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            this.choferesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.choferesToolStripMenuItem.Text = "Choferes";
            this.choferesToolStripMenuItem.Click += new System.EventHandler(this.choferesToolStripMenuItem_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 156);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtExaminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtNroCarta);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtExaminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtNroCarta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choferesToolStripMenuItem;
    }
}


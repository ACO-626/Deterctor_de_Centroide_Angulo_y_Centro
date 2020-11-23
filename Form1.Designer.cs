namespace Deterctor_de_Contornos
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bordeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectarBordeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.detectarCentroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectarCentroideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectarÁnguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.bordeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1691, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // bordeToolStripMenuItem
            // 
            this.bordeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detectarBordeToolStripMenuItem,
            this.detectarCentroToolStripMenuItem,
            this.detectarCentroideToolStripMenuItem,
            this.detectarÁnguloToolStripMenuItem});
            this.bordeToolStripMenuItem.Name = "bordeToolStripMenuItem";
            this.bordeToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.bordeToolStripMenuItem.Text = "Borde";
            // 
            // detectarBordeToolStripMenuItem
            // 
            this.detectarBordeToolStripMenuItem.Name = "detectarBordeToolStripMenuItem";
            this.detectarBordeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.detectarBordeToolStripMenuItem.Text = "Detectar Borde";
            this.detectarBordeToolStripMenuItem.Click += new System.EventHandler(this.detectarBordeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(777, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(868, 50);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(777, 503);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // detectarCentroToolStripMenuItem
            // 
            this.detectarCentroToolStripMenuItem.Name = "detectarCentroToolStripMenuItem";
            this.detectarCentroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.detectarCentroToolStripMenuItem.Text = "Detectar Centro";
            this.detectarCentroToolStripMenuItem.Click += new System.EventHandler(this.detectarCentroToolStripMenuItem_Click);
            // 
            // detectarCentroideToolStripMenuItem
            // 
            this.detectarCentroideToolStripMenuItem.Name = "detectarCentroideToolStripMenuItem";
            this.detectarCentroideToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.detectarCentroideToolStripMenuItem.Text = "Detectar Centroide";
            // 
            // detectarÁnguloToolStripMenuItem
            // 
            this.detectarÁnguloToolStripMenuItem.Name = "detectarÁnguloToolStripMenuItem";
            this.detectarÁnguloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.detectarÁnguloToolStripMenuItem.Text = "Detectar Ángulo";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1691, 751);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "Detector de contorno";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bordeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectarBordeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem detectarCentroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectarCentroideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectarÁnguloToolStripMenuItem;
    }
}


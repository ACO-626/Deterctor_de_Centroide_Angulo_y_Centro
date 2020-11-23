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
            this.detectarCentroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectarCentroideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectarÁnguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNumObj = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericBorde1 = new System.Windows.Forms.NumericUpDown();
            this.numericBorde2 = new System.Windows.Forms.NumericUpDown();
            this.btnBorde = new System.Windows.Forms.Button();
            this.btnCentros = new System.Windows.Forms.Button();
            this.numericSenCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorde1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorde2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSenCount)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1331, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
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
            this.bordeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.bordeToolStripMenuItem.Text = "Borde";
            // 
            // detectarBordeToolStripMenuItem
            // 
            this.detectarBordeToolStripMenuItem.Name = "detectarBordeToolStripMenuItem";
            this.detectarBordeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.detectarBordeToolStripMenuItem.Text = "Detectar Borde";
            this.detectarBordeToolStripMenuItem.Click += new System.EventHandler(this.detectarBordeToolStripMenuItem_Click);
            // 
            // detectarCentroToolStripMenuItem
            // 
            this.detectarCentroToolStripMenuItem.Name = "detectarCentroToolStripMenuItem";
            this.detectarCentroToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.detectarCentroToolStripMenuItem.Text = "Detectar Centro";
            this.detectarCentroToolStripMenuItem.Click += new System.EventHandler(this.detectarCentroToolStripMenuItem_Click);
            // 
            // detectarCentroideToolStripMenuItem
            // 
            this.detectarCentroideToolStripMenuItem.Name = "detectarCentroideToolStripMenuItem";
            this.detectarCentroideToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.detectarCentroideToolStripMenuItem.Text = "Detectar Centroide";
            // 
            // detectarÁnguloToolStripMenuItem
            // 
            this.detectarÁnguloToolStripMenuItem.Name = "detectarÁnguloToolStripMenuItem";
            this.detectarÁnguloToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.detectarÁnguloToolStripMenuItem.Text = "Detectar Ángulo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(633, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(583, 409);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericSenCount);
            this.panel1.Controls.Add(this.btnCentros);
            this.panel1.Controls.Add(this.lbNumObj);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericBorde1);
            this.panel1.Controls.Add(this.numericBorde2);
            this.panel1.Controls.Add(this.btnBorde);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1331, 81);
            this.panel1.TabIndex = 3;
            // 
            // lbNumObj
            // 
            this.lbNumObj.AutoSize = true;
            this.lbNumObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumObj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNumObj.Location = new System.Drawing.Point(421, 22);
            this.lbNumObj.Name = "lbNumObj";
            this.lbNumObj.Size = new System.Drawing.Size(41, 31);
            this.lbNumObj.TabIndex = 8;
            this.lbNumObj.Text = "---";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(339, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 75);
            this.button4.TabIndex = 7;
            this.button4.Text = "CONTAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1130, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "CENTRÓIDDE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 75);
            this.button2.TabIndex = 5;
            this.button2.Text = "ÁNGULO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(107, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "LÍMITES ";
            // 
            // numericBorde1
            // 
            this.numericBorde1.Location = new System.Drawing.Point(107, 32);
            this.numericBorde1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBorde1.Name = "numericBorde1";
            this.numericBorde1.Size = new System.Drawing.Size(53, 20);
            this.numericBorde1.TabIndex = 2;
            this.numericBorde1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericBorde2
            // 
            this.numericBorde2.Location = new System.Drawing.Point(107, 58);
            this.numericBorde2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBorde2.Name = "numericBorde2";
            this.numericBorde2.Size = new System.Drawing.Size(53, 20);
            this.numericBorde2.TabIndex = 1;
            this.numericBorde2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // btnBorde
            // 
            this.btnBorde.Location = new System.Drawing.Point(25, 3);
            this.btnBorde.Name = "btnBorde";
            this.btnBorde.Size = new System.Drawing.Size(76, 75);
            this.btnBorde.TabIndex = 0;
            this.btnBorde.Text = "BORDE";
            this.btnBorde.UseVisualStyleBackColor = true;
            this.btnBorde.Click += new System.EventHandler(this.btnBorde_Click);
            // 
            // btnCentros
            // 
            this.btnCentros.Location = new System.Drawing.Point(175, 6);
            this.btnCentros.Name = "btnCentros";
            this.btnCentros.Size = new System.Drawing.Size(76, 75);
            this.btnCentros.TabIndex = 9;
            this.btnCentros.Text = "CENTROS";
            this.btnCentros.UseVisualStyleBackColor = true;
            this.btnCentros.Click += new System.EventHandler(this.btnCentros_Click);
            // 
            // numericSenCount
            // 
            this.numericSenCount.Location = new System.Drawing.Point(421, 58);
            this.numericSenCount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericSenCount.Name = "numericSenCount";
            this.numericSenCount.Size = new System.Drawing.Size(53, 20);
            this.numericSenCount.TabIndex = 10;
            this.numericSenCount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(480, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "SENSIBILIDAD";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1331, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Detector de contorno";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorde1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorde2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSenCount)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericBorde1;
        private System.Windows.Forms.NumericUpDown numericBorde2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbNumObj;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCentros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericSenCount;
    }
}


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
            this.button1 = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericSenCount = new System.Windows.Forms.NumericUpDown();
            this.btnCentros = new System.Windows.Forms.Button();
            this.lbNumObj = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCentro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericBorde1 = new System.Windows.Forms.NumericUpDown();
            this.numericBorde2 = new System.Windows.Forms.NumericUpDown();
            this.btnBorde = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSenCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorde1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorde2)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1721, 28);
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
            this.bordeToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.bordeToolStripMenuItem.Text = "Borde";
            // 
            // detectarBordeToolStripMenuItem
            // 
            this.detectarBordeToolStripMenuItem.Name = "detectarBordeToolStripMenuItem";
            this.detectarBordeToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.detectarBordeToolStripMenuItem.Text = "Detectar Borde";
            this.detectarBordeToolStripMenuItem.Click += new System.EventHandler(this.detectarBordeToolStripMenuItem_Click);
            // 
            // detectarCentroToolStripMenuItem
            // 
            this.detectarCentroToolStripMenuItem.Name = "detectarCentroToolStripMenuItem";
            this.detectarCentroToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.detectarCentroToolStripMenuItem.Text = "Detectar Centro";
            this.detectarCentroToolStripMenuItem.Click += new System.EventHandler(this.detectarCentroToolStripMenuItem_Click);
            // 
            // detectarCentroideToolStripMenuItem
            // 
            this.detectarCentroideToolStripMenuItem.Name = "detectarCentroideToolStripMenuItem";
            this.detectarCentroideToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.detectarCentroideToolStripMenuItem.Text = "Detectar Centroide";
            // 
            // detectarÁnguloToolStripMenuItem
            // 
            this.detectarÁnguloToolStripMenuItem.Name = "detectarÁnguloToolStripMenuItem";
            this.detectarÁnguloToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.detectarÁnguloToolStripMenuItem.Text = "Detectar Ángulo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(777, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(844, 151);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(777, 503);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericSenCount);
            this.panel1.Controls.Add(this.btnCentros);
            this.panel1.Controls.Add(this.lbNumObj);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnCentro);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericBorde1);
            this.panel1.Controls.Add(this.numericBorde2);
            this.panel1.Controls.Add(this.btnBorde);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1721, 100);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1320, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 92);
            this.button1.TabIndex = 13;
            this.button1.Text = "VEHÍCULO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(1060, 16);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(252, 39);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.Text = "+ INFORMACIÓN";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(692, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "SENSIBILIDAD";
            // 
            // numericSenCount
            // 
            this.numericSenCount.Location = new System.Drawing.Point(613, 71);
            this.numericSenCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericSenCount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericSenCount.Name = "numericSenCount";
            this.numericSenCount.Size = new System.Drawing.Size(71, 22);
            this.numericSenCount.TabIndex = 10;
            this.numericSenCount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnCentros
            // 
            this.btnCentros.Location = new System.Drawing.Point(233, 7);
            this.btnCentros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCentros.Name = "btnCentros";
            this.btnCentros.Size = new System.Drawing.Size(153, 92);
            this.btnCentros.TabIndex = 9;
            this.btnCentros.Text = "CENTROIDE";
            this.btnCentros.UseVisualStyleBackColor = true;
            this.btnCentros.Click += new System.EventHandler(this.btnCentros_Click);
            // 
            // lbNumObj
            // 
            this.lbNumObj.AutoSize = true;
            this.lbNumObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumObj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNumObj.Location = new System.Drawing.Point(613, 27);
            this.lbNumObj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumObj.Name = "lbNumObj";
            this.lbNumObj.Size = new System.Drawing.Size(50, 39);
            this.lbNumObj.TabIndex = 8;
            this.lbNumObj.Text = "---";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(504, 7);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 92);
            this.button4.TabIndex = 7;
            this.button4.Text = "CONTAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCentro
            // 
            this.btnCentro.Location = new System.Drawing.Point(1060, 57);
            this.btnCentro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCentro.Name = "btnCentro";
            this.btnCentro.Size = new System.Drawing.Size(252, 39);
            this.btnCentro.TabIndex = 6;
            this.btnCentro.Text = "CENTRO DE OBJETO";
            this.btnCentro.UseVisualStyleBackColor = true;
            this.btnCentro.Click += new System.EventHandler(this.btnCentro_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 92);
            this.button2.TabIndex = 5;
            this.button2.Text = "ÁNGULO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(143, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "LÍMITES ";
            // 
            // numericBorde1
            // 
            this.numericBorde1.Location = new System.Drawing.Point(143, 39);
            this.numericBorde1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericBorde1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBorde1.Name = "numericBorde1";
            this.numericBorde1.Size = new System.Drawing.Size(71, 22);
            this.numericBorde1.TabIndex = 2;
            this.numericBorde1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericBorde2
            // 
            this.numericBorde2.Location = new System.Drawing.Point(143, 71);
            this.numericBorde2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericBorde2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBorde2.Name = "numericBorde2";
            this.numericBorde2.Size = new System.Drawing.Size(71, 22);
            this.numericBorde2.TabIndex = 1;
            this.numericBorde2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // btnBorde
            // 
            this.btnBorde.Location = new System.Drawing.Point(33, 4);
            this.btnBorde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorde.Name = "btnBorde";
            this.btnBorde.Size = new System.Drawing.Size(101, 92);
            this.btnBorde.TabIndex = 0;
            this.btnBorde.Text = "BORDE";
            this.btnBorde.UseVisualStyleBackColor = true;
            this.btnBorde.Click += new System.EventHandler(this.btnBorde_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1721, 751);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detector de contorno";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSenCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorde1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBorde2)).EndInit();
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
        private System.Windows.Forms.Button btnCentro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbNumObj;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCentros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericSenCount;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button button1;
    }
}


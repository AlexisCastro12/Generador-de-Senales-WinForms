
namespace WFProyectoGenerador
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Generador = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tBfrec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBAmpP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.gBSeñales = new System.Windows.Forms.GroupBox();
            this.RBPulsos = new System.Windows.Forms.RadioButton();
            this.RBSierra = new System.Windows.Forms.RadioButton();
            this.RBTriang = new System.Windows.Forms.RadioButton();
            this.RBCos = new System.Windows.Forms.RadioButton();
            this.RBSen = new System.Windows.Forms.RadioButton();
            this.RBContinua = new System.Windows.Forms.RadioButton();
            this.RBCuadrada = new System.Windows.Forms.RadioButton();
            this.BtnRnStp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Generador)).BeginInit();
            this.gBSeñales.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Generador
            // 
            chartArea1.Name = "ChartArea1";
            this.Generador.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Generador.Legends.Add(legend1);
            this.Generador.Location = new System.Drawing.Point(291, 36);
            this.Generador.Name = "Generador";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Señal Generada";
            this.Generador.Series.Add(series1);
            this.Generador.Size = new System.Drawing.Size(575, 431);
            this.Generador.TabIndex = 0;
            this.Generador.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tBfrec
            // 
            this.tBfrec.Location = new System.Drawing.Point(77, 376);
            this.tBfrec.Name = "tBfrec";
            this.tBfrec.Size = new System.Drawing.Size(106, 20);
            this.tBfrec.TabIndex = 8;
            this.tBfrec.Text = "1";
            this.tBfrec.TextChanged += new System.EventHandler(this.tBfrec_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label4.Location = new System.Drawing.Point(44, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "frec";
            // 
            // tBAmpP
            // 
            this.tBAmpP.Location = new System.Drawing.Point(77, 407);
            this.tBAmpP.Name = "tBAmpP";
            this.tBAmpP.Size = new System.Drawing.Size(106, 20);
            this.tBAmpP.TabIndex = 10;
            this.tBAmpP.Text = "1";
            this.tBAmpP.TextChanged += new System.EventHandler(this.tBAmpP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label1.Location = new System.Drawing.Point(44, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label2.Location = new System.Drawing.Point(189, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Volts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label3.Location = new System.Drawing.Point(189, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hz";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(136, 441);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(120, 23);
            this.btnAplicar.TabIndex = 14;
            this.btnAplicar.Text = "Generar Señal";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // gBSeñales
            // 
            this.gBSeñales.Controls.Add(this.RBCuadrada);
            this.gBSeñales.Controls.Add(this.RBContinua);
            this.gBSeñales.Controls.Add(this.RBPulsos);
            this.gBSeñales.Controls.Add(this.RBSierra);
            this.gBSeñales.Controls.Add(this.RBTriang);
            this.gBSeñales.Controls.Add(this.RBCos);
            this.gBSeñales.Controls.Add(this.RBSen);
            this.gBSeñales.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.gBSeñales.Location = new System.Drawing.Point(14, 132);
            this.gBSeñales.Name = "gBSeñales";
            this.gBSeñales.Size = new System.Drawing.Size(254, 238);
            this.gBSeñales.TabIndex = 15;
            this.gBSeñales.TabStop = false;
            this.gBSeñales.Text = "Señales";
            // 
            // RBPulsos
            // 
            this.RBPulsos.AutoSize = true;
            this.RBPulsos.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.RBPulsos.Location = new System.Drawing.Point(6, 170);
            this.RBPulsos.Name = "RBPulsos";
            this.RBPulsos.Size = new System.Drawing.Size(124, 24);
            this.RBPulsos.TabIndex = 20;
            this.RBPulsos.Text = "Tren de Impulsos";
            this.RBPulsos.UseVisualStyleBackColor = true;
            this.RBPulsos.CheckedChanged += new System.EventHandler(this.RBPulsos_CheckedChanged);
            // 
            // RBSierra
            // 
            this.RBSierra.AutoSize = true;
            this.RBSierra.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.RBSierra.Location = new System.Drawing.Point(6, 110);
            this.RBSierra.Name = "RBSierra";
            this.RBSierra.Size = new System.Drawing.Size(116, 24);
            this.RBSierra.TabIndex = 19;
            this.RBSierra.Text = "Diente de Sierra";
            this.RBSierra.UseVisualStyleBackColor = true;
            this.RBSierra.CheckedChanged += new System.EventHandler(this.RBSierra_CheckedChanged);
            // 
            // RBTriang
            // 
            this.RBTriang.AutoSize = true;
            this.RBTriang.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.RBTriang.Location = new System.Drawing.Point(6, 80);
            this.RBTriang.Name = "RBTriang";
            this.RBTriang.Size = new System.Drawing.Size(85, 24);
            this.RBTriang.TabIndex = 18;
            this.RBTriang.Text = "Triangular";
            this.RBTriang.UseVisualStyleBackColor = true;
            this.RBTriang.CheckedChanged += new System.EventHandler(this.RBTriang_CheckedChanged);
            // 
            // RBCos
            // 
            this.RBCos.AutoSize = true;
            this.RBCos.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.RBCos.Location = new System.Drawing.Point(6, 50);
            this.RBCos.Name = "RBCos";
            this.RBCos.Size = new System.Drawing.Size(90, 24);
            this.RBCos.TabIndex = 17;
            this.RBCos.Text = "Cosenoidal";
            this.RBCos.UseVisualStyleBackColor = true;
            this.RBCos.CheckedChanged += new System.EventHandler(this.RBCos_CheckedChanged);
            // 
            // RBSen
            // 
            this.RBSen.AutoSize = true;
            this.RBSen.Checked = true;
            this.RBSen.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.RBSen.Location = new System.Drawing.Point(6, 20);
            this.RBSen.Name = "RBSen";
            this.RBSen.Size = new System.Drawing.Size(76, 24);
            this.RBSen.TabIndex = 16;
            this.RBSen.TabStop = true;
            this.RBSen.Text = "Senoidal";
            this.RBSen.UseVisualStyleBackColor = true;
            this.RBSen.CheckedChanged += new System.EventHandler(this.RBSen_CheckedChanged);
            // 
            // RBContinua
            // 
            this.RBContinua.AutoSize = true;
            this.RBContinua.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.RBContinua.Location = new System.Drawing.Point(6, 200);
            this.RBContinua.Name = "RBContinua";
            this.RBContinua.Size = new System.Drawing.Size(97, 24);
            this.RBContinua.TabIndex = 21;
            this.RBContinua.Text = "Señal de CD";
            this.RBContinua.UseVisualStyleBackColor = true;
            this.RBContinua.CheckedChanged += new System.EventHandler(this.RBContinua_CheckedChanged);
            // 
            // RBCuadrada
            // 
            this.RBCuadrada.AutoSize = true;
            this.RBCuadrada.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.RBCuadrada.Location = new System.Drawing.Point(6, 140);
            this.RBCuadrada.Name = "RBCuadrada";
            this.RBCuadrada.Size = new System.Drawing.Size(82, 24);
            this.RBCuadrada.TabIndex = 22;
            this.RBCuadrada.Text = "Cuadrada";
            this.RBCuadrada.UseVisualStyleBackColor = true;
            this.RBCuadrada.CheckedChanged += new System.EventHandler(this.RBCuadrada_CheckedChanged);
            // 
            // BtnRnStp
            // 
            this.BtnRnStp.Location = new System.Drawing.Point(20, 441);
            this.BtnRnStp.Name = "BtnRnStp";
            this.BtnRnStp.Size = new System.Drawing.Size(103, 23);
            this.BtnRnStp.TabIndex = 16;
            this.BtnRnStp.Text = "Run/Stop";
            this.BtnRnStp.UseVisualStyleBackColor = true;
            this.BtnRnStp.Click += new System.EventHandler(this.BtnRnStp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Location = new System.Drawing.Point(156, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(122, 90);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Generador \r\nde Señales Electrónicas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFProyectoGenerador.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(485, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tiempo (s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(294, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 170);
            this.label6.TabIndex = 21;
            this.label6.Text = "A\r\nm\r\np\r\nl\r\ni\r\nt\r\nu\r\nd\r\n\r\n(V)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(888, 502);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnRnStp);
            this.Controls.Add(this.gBSeñales);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBAmpP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBfrec);
            this.Controls.Add(this.Generador);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(904, 541);
            this.MinimumSize = new System.Drawing.Size(904, 541);
            this.Name = "Form1";
            this.Text = "Generador de Señales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Generador)).EndInit();
            this.gBSeñales.ResumeLayout(false);
            this.gBSeñales.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Generador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tBfrec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBAmpP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.GroupBox gBSeñales;
        private System.Windows.Forms.RadioButton RBCos;
        private System.Windows.Forms.RadioButton RBSen;
        private System.Windows.Forms.RadioButton RBPulsos;
        private System.Windows.Forms.RadioButton RBSierra;
        private System.Windows.Forms.RadioButton RBTriang;
        private System.Windows.Forms.RadioButton RBContinua;
        private System.Windows.Forms.RadioButton RBCuadrada;
        private System.Windows.Forms.Button BtnRnStp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


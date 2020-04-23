namespace GeneradorDeDistribuciones
{
    partial class Generador
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.gb_poisson = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_poisson_media = new System.Windows.Forms.MaskedTextBox();
            this.gb_normal = new System.Windows.Forms.GroupBox();
            this.txt_normal_desviacion = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_normal_media = new System.Windows.Forms.MaskedTextBox();
            this.gb_exponencial = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_expNeg_param = new System.Windows.Forms.MaskedTextBox();
            this.cb_expNeg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TipoDistribucion = new System.Windows.Forms.ComboBox();
            this.gb_uniforme = new System.Windows.Forms.GroupBox();
            this.txt_uniforme_ls = new System.Windows.Forms.MaskedTextBox();
            this.txt_uniforme_li = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.MaskedTextBox();
            this.grilla_generados = new System.Windows.Forms.DataGridView();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_intervalos = new System.Windows.Forms.ComboBox();
            this.gb_pruebas = new System.Windows.Forms.GroupBox();
            this.btn_csv = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cant_interv = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.check_intervalos = new System.Windows.Forms.CheckBox();
            this.gb_1.SuspendLayout();
            this.gb_poisson.SuspendLayout();
            this.gb_normal.SuspendLayout();
            this.gb_exponencial.SuspendLayout();
            this.gb_uniforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_generados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.gb_pruebas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_1
            // 
            this.gb_1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_1.Controls.Add(this.label8);
            this.gb_1.Controls.Add(this.label7);
            this.gb_1.Controls.Add(this.label6);
            this.gb_1.Controls.Add(this.btn_generar);
            this.gb_1.Controls.Add(this.gb_poisson);
            this.gb_1.Controls.Add(this.gb_normal);
            this.gb_1.Controls.Add(this.gb_exponencial);
            this.gb_1.Controls.Add(this.label2);
            this.gb_1.Controls.Add(this.cb_TipoDistribucion);
            this.gb_1.Controls.Add(this.gb_uniforme);
            this.gb_1.Controls.Add(this.label1);
            this.gb_1.Controls.Add(this.txt_cantidad);
            this.gb_1.Location = new System.Drawing.Point(5, 3);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(803, 209);
            this.gb_1.TabIndex = 0;
            this.gb_1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Poisson";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Normal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Exponencial Negativa";
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(459, 13);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(109, 34);
            this.btn_generar.TabIndex = 7;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.Btn_generar_Click);
            // 
            // gb_poisson
            // 
            this.gb_poisson.Controls.Add(this.label11);
            this.gb_poisson.Controls.Add(this.txt_poisson_media);
            this.gb_poisson.Location = new System.Drawing.Point(614, 83);
            this.gb_poisson.Name = "gb_poisson";
            this.gb_poisson.Size = new System.Drawing.Size(183, 120);
            this.gb_poisson.TabIndex = 6;
            this.gb_poisson.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Media";
            // 
            // txt_poisson_media
            // 
            this.txt_poisson_media.Location = new System.Drawing.Point(75, 20);
            this.txt_poisson_media.Name = "txt_poisson_media";
            this.txt_poisson_media.Size = new System.Drawing.Size(94, 20);
            this.txt_poisson_media.TabIndex = 0;
            // 
            // gb_normal
            // 
            this.gb_normal.Controls.Add(this.txt_normal_desviacion);
            this.gb_normal.Controls.Add(this.label10);
            this.gb_normal.Controls.Add(this.label9);
            this.gb_normal.Controls.Add(this.txt_normal_media);
            this.gb_normal.Location = new System.Drawing.Point(411, 83);
            this.gb_normal.Name = "gb_normal";
            this.gb_normal.Size = new System.Drawing.Size(183, 120);
            this.gb_normal.TabIndex = 6;
            this.gb_normal.TabStop = false;
            // 
            // txt_normal_desviacion
            // 
            this.txt_normal_desviacion.Location = new System.Drawing.Point(73, 53);
            this.txt_normal_desviacion.Name = "txt_normal_desviacion";
            this.txt_normal_desviacion.Size = new System.Drawing.Size(94, 20);
            this.txt_normal_desviacion.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Desviación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Media";
            // 
            // txt_normal_media
            // 
            this.txt_normal_media.Location = new System.Drawing.Point(73, 20);
            this.txt_normal_media.Name = "txt_normal_media";
            this.txt_normal_media.Size = new System.Drawing.Size(94, 20);
            this.txt_normal_media.TabIndex = 0;
            // 
            // gb_exponencial
            // 
            this.gb_exponencial.Controls.Add(this.label5);
            this.gb_exponencial.Controls.Add(this.txt_expNeg_param);
            this.gb_exponencial.Controls.Add(this.cb_expNeg);
            this.gb_exponencial.Location = new System.Drawing.Point(208, 83);
            this.gb_exponencial.Name = "gb_exponencial";
            this.gb_exponencial.Size = new System.Drawing.Size(183, 120);
            this.gb_exponencial.TabIndex = 5;
            this.gb_exponencial.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Parametro";
            // 
            // txt_expNeg_param
            // 
            this.txt_expNeg_param.Location = new System.Drawing.Point(65, 46);
            this.txt_expNeg_param.Name = "txt_expNeg_param";
            this.txt_expNeg_param.Size = new System.Drawing.Size(100, 20);
            this.txt_expNeg_param.TabIndex = 1;
            // 
            // cb_expNeg
            // 
            this.cb_expNeg.FormattingEnabled = true;
            this.cb_expNeg.Items.AddRange(new object[] {
            "frecuencia (lambda)",
            "media"});
            this.cb_expNeg.Location = new System.Drawing.Point(44, 15);
            this.cb_expNeg.Name = "cb_expNeg";
            this.cb_expNeg.Size = new System.Drawing.Size(121, 21);
            this.cb_expNeg.TabIndex = 0;
            this.cb_expNeg.Text = "-Tipo de Parametro-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uniforme (A-B)";
            // 
            // cb_TipoDistribucion
            // 
            this.cb_TipoDistribucion.FormattingEnabled = true;
            this.cb_TipoDistribucion.Items.AddRange(new object[] {
            "Uniforme",
            "Exponencial Negativa",
            "Normal",
            "Poisson"});
            this.cb_TipoDistribucion.Location = new System.Drawing.Point(232, 21);
            this.cb_TipoDistribucion.Name = "cb_TipoDistribucion";
            this.cb_TipoDistribucion.Size = new System.Drawing.Size(194, 21);
            this.cb_TipoDistribucion.TabIndex = 2;
            this.cb_TipoDistribucion.Text = "-Seleccione Distribución-";
            this.cb_TipoDistribucion.SelectedIndexChanged += new System.EventHandler(this.Cb_TipoDistribucion_SelectedIndexChanged);
            // 
            // gb_uniforme
            // 
            this.gb_uniforme.Controls.Add(this.txt_uniforme_ls);
            this.gb_uniforme.Controls.Add(this.txt_uniforme_li);
            this.gb_uniforme.Controls.Add(this.label4);
            this.gb_uniforme.Controls.Add(this.label3);
            this.gb_uniforme.Location = new System.Drawing.Point(7, 83);
            this.gb_uniforme.Name = "gb_uniforme";
            this.gb_uniforme.Size = new System.Drawing.Size(182, 120);
            this.gb_uniforme.TabIndex = 3;
            this.gb_uniforme.TabStop = false;
            // 
            // txt_uniforme_ls
            // 
            this.txt_uniforme_ls.Location = new System.Drawing.Point(94, 47);
            this.txt_uniforme_ls.Name = "txt_uniforme_ls";
            this.txt_uniforme_ls.Size = new System.Drawing.Size(69, 20);
            this.txt_uniforme_ls.TabIndex = 3;
            // 
            // txt_uniforme_li
            // 
            this.txt_uniforme_li.Location = new System.Drawing.Point(94, 20);
            this.txt_uniforme_li.Name = "txt_uniforme_li";
            this.txt_uniforme_li.Size = new System.Drawing.Size(69, 20);
            this.txt_uniforme_li.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Limite Superior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Limite Inferior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad a Generar";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(131, 21);
            this.txt_cantidad.Mask = "9999999";
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(82, 20);
            this.txt_cantidad.TabIndex = 0;
            this.txt_cantidad.ValidatingType = typeof(int);
            // 
            // grilla_generados
            // 
            this.grilla_generados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_generados.Location = new System.Drawing.Point(5, 218);
            this.grilla_generados.Name = "grilla_generados";
            this.grilla_generados.Size = new System.Drawing.Size(280, 343);
            this.grilla_generados.TabIndex = 1;
            // 
            // grafico
            // 
            this.grafico.BackColor = System.Drawing.Color.Gray;
            this.grafico.BorderlineColor = System.Drawing.Color.Linen;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(291, 246);
            this.grafico.Name = "grafico";
            this.grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.Color = System.Drawing.Color.White;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
            series1.SmartLabelStyle.Enabled = false;
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(517, 315);
            this.grafico.TabIndex = 2;
            // 
            // cb_intervalos
            // 
            this.cb_intervalos.FormattingEnabled = true;
            this.cb_intervalos.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "50",
            "100"});
            this.cb_intervalos.Location = new System.Drawing.Point(668, 219);
            this.cb_intervalos.Name = "cb_intervalos";
            this.cb_intervalos.Size = new System.Drawing.Size(140, 21);
            this.cb_intervalos.TabIndex = 3;
            this.cb_intervalos.Text = "- Cantidad Intervalos - ";
            this.cb_intervalos.SelectedIndexChanged += new System.EventHandler(this.Cb_intervalos_SelectedIndexChanged);
            // 
            // gb_pruebas
            // 
            this.gb_pruebas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_pruebas.Controls.Add(this.btn_csv);
            this.gb_pruebas.Controls.Add(this.label13);
            this.gb_pruebas.Controls.Add(this.txt_cant_interv);
            this.gb_pruebas.Controls.Add(this.label12);
            this.gb_pruebas.Location = new System.Drawing.Point(815, 3);
            this.gb_pruebas.Name = "gb_pruebas";
            this.gb_pruebas.Size = new System.Drawing.Size(220, 209);
            this.gb_pruebas.TabIndex = 4;
            this.gb_pruebas.TabStop = false;
            // 
            // btn_csv
            // 
            this.btn_csv.Location = new System.Drawing.Point(61, 100);
            this.btn_csv.Name = "btn_csv";
            this.btn_csv.Size = new System.Drawing.Size(103, 23);
            this.btn_csv.TabIndex = 3;
            this.btn_csv.Text = "Exportar TXT";
            this.btn_csv.UseVisualStyleBackColor = true;
            this.btn_csv.Click += new System.EventHandler(this.Btn_csv_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Cantidad Intervalos";
            // 
            // txt_cant_interv
            // 
            this.txt_cant_interv.Location = new System.Drawing.Point(114, 57);
            this.txt_cant_interv.Mask = "9999";
            this.txt_cant_interv.Name = "txt_cant_interv";
            this.txt_cant_interv.Size = new System.Drawing.Size(100, 20);
            this.txt_cant_interv.TabIndex = 1;
            this.txt_cant_interv.ValidatingType = typeof(int);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Prueba de Bondad de Ajuste";
            // 
            // check_intervalos
            // 
            this.check_intervalos.AutoSize = true;
            this.check_intervalos.Location = new System.Drawing.Point(306, 219);
            this.check_intervalos.Name = "check_intervalos";
            this.check_intervalos.Size = new System.Drawing.Size(235, 17);
            this.check_intervalos.TabIndex = 5;
            this.check_intervalos.Text = "Filtrar valores nulos (Poisson Recomendado)";
            this.check_intervalos.UseVisualStyleBackColor = true;
            this.check_intervalos.CheckedChanged += new System.EventHandler(this.Check_intervalos_CheckedChanged);
            // 
            // Generador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1036, 565);
            this.Controls.Add(this.check_intervalos);
            this.Controls.Add(this.gb_pruebas);
            this.Controls.Add(this.cb_intervalos);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.grilla_generados);
            this.Controls.Add(this.gb_1);
            this.Name = "Generador";
            this.Text = "Generador de Distribuciones";
            this.Load += new System.EventHandler(this.Generador_Load);
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            this.gb_poisson.ResumeLayout(false);
            this.gb_poisson.PerformLayout();
            this.gb_normal.ResumeLayout(false);
            this.gb_normal.PerformLayout();
            this.gb_exponencial.ResumeLayout(false);
            this.gb_exponencial.PerformLayout();
            this.gb_uniforme.ResumeLayout(false);
            this.gb_uniforme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_generados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.gb_pruebas.ResumeLayout(false);
            this.gb_pruebas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.ComboBox cb_TipoDistribucion;
        private System.Windows.Forms.GroupBox gb_uniforme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grilla_generados;
        private System.Windows.Forms.MaskedTextBox txt_uniforme_ls;
        private System.Windows.Forms.MaskedTextBox txt_uniforme_li;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_poisson;
        private System.Windows.Forms.GroupBox gb_normal;
        private System.Windows.Forms.GroupBox gb_exponencial;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.MaskedTextBox txt_expNeg_param;
        private System.Windows.Forms.ComboBox cb_expNeg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_normal_media;
        private System.Windows.Forms.MaskedTextBox txt_normal_desviacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.ComboBox cb_intervalos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_poisson_media;
        private System.Windows.Forms.GroupBox gb_pruebas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_csv;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txt_cant_interv;
        private System.Windows.Forms.CheckBox check_intervalos;
    }
}


namespace Prezzo_di_equilibrio
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.tb_g = new System.Windows.Forms.TextBox();
            this.tb_f = new System.Windows.Forms.TextBox();
            this.btn_calcola = new System.Windows.Forms.Button();
            this.Quantità = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_qe = new System.Windows.Forms.Label();
            this.lbl_pe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(231, 107);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(368, 377);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantità,
            this.Domanda,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(633, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 470);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "d = a - b*q";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "a =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "b =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "o= c + q^f/g";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "c =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "g =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "f =";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(57, 104);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(54, 20);
            this.tb_a.TabIndex = 12;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(57, 139);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(54, 20);
            this.tb_b.TabIndex = 13;
            // 
            // tb_c
            // 
            this.tb_c.Location = new System.Drawing.Point(57, 247);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(54, 20);
            this.tb_c.TabIndex = 14;
            // 
            // tb_g
            // 
            this.tb_g.Location = new System.Drawing.Point(57, 349);
            this.tb_g.Name = "tb_g";
            this.tb_g.Size = new System.Drawing.Size(54, 20);
            this.tb_g.TabIndex = 15;
            // 
            // tb_f
            // 
            this.tb_f.Location = new System.Drawing.Point(57, 300);
            this.tb_f.Name = "tb_f";
            this.tb_f.Size = new System.Drawing.Size(54, 20);
            this.tb_f.TabIndex = 16;
            // 
            // btn_calcola
            // 
            this.btn_calcola.Location = new System.Drawing.Point(31, 479);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(140, 49);
            this.btn_calcola.TabIndex = 17;
            this.btn_calcola.Text = "CALCOLA";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.btn_calcola_Click);
            // 
            // Quantità
            // 
            this.Quantità.HeaderText = "Quantità";
            this.Quantità.Name = "Quantità";
            // 
            // Domanda
            // 
            this.Domanda.HeaderText = "Domanda";
            this.Domanda.Name = "Domanda";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Offerta";
            this.Column3.Name = "Column3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(329, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "PREZZO DI EQUILIBRIO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Quantità di equilibrio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Prezzo di equilibrio:";
            // 
            // lbl_qe
            // 
            this.lbl_qe.AutoSize = true;
            this.lbl_qe.Location = new System.Drawing.Point(140, 415);
            this.lbl_qe.Name = "lbl_qe";
            this.lbl_qe.Size = new System.Drawing.Size(13, 13);
            this.lbl_qe.TabIndex = 21;
            this.lbl_qe.Text = "?";
            // 
            // lbl_pe
            // 
            this.lbl_pe.AutoSize = true;
            this.lbl_pe.Location = new System.Drawing.Point(140, 446);
            this.lbl_pe.Name = "lbl_pe";
            this.lbl_pe.Size = new System.Drawing.Size(13, 13);
            this.lbl_pe.TabIndex = 22;
            this.lbl_pe.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1027, 633);
            this.Controls.Add(this.lbl_pe);
            this.Controls.Add(this.lbl_qe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_calcola);
            this.Controls.Add(this.tb_f);
            this.Controls.Add(this.tb_g);
            this.Controls.Add(this.tb_c);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_c;
        private System.Windows.Forms.TextBox tb_g;
        private System.Windows.Forms.TextBox tb_f;
        private System.Windows.Forms.Button btn_calcola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantità;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_qe;
        private System.Windows.Forms.Label lbl_pe;
    }
}


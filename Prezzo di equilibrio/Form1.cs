using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prezzo_di_equilibrio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_q.Text))
            {
                MessageBox.Show("Inserisci un valore nella textbox.");    
            }

            int q = int.Parse(tb_q.Text);

            if(int.TryParse(tb_q.Text, out q) == false)
            {
                MessageBox.Show("Inserisci un valore numerico valido.");
                return;
            }

            int d = 90- 4*q;    
            int o = 10 + (q^3/100);

            int a = 78;

            MessageBox.Show("Domanda: " + d + "\nOfferta: " + o);



            chart1.Series.Clear();
            chart1.Titles.Add("Grafico domanda-offerta");

            chart1.Series.Add("Domanda");
            chart1.Series["Domanda"].Color = Color.Green;
            chart1.Series["Domanda"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series.Add("Offerta");
            chart1.Series["Offerta"].Color = Color.Blue;
            chart1.Series["Offerta"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart1.Series["Domanda"].Points.AddXY(1, 40);
            chart1.Series["Domanda"].Points.AddXY(2, 60);
            chart1.Series["Domanda"].Points.AddXY(3, 80);
            chart1.Series["Domanda"].Points.AddXY(4, 100);
            chart1.Series["Offerta"].Points.AddXY(5, 110);
            chart1.Series["Offerta"].Points.AddXY(6, 80);
            chart1.Series["Offerta"].Points.AddXY(7, 70);
        }
    }
}

using System;

using System.Drawing;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Prezzo_di_equilibrio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




       

        private void btn_calcola_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tb_a.Text);
            double b = double.Parse(tb_b.Text);


            double c = double.Parse(tb_c.Text);
            double f = double.Parse(tb_f.Text);
            double g = double.Parse(tb_g.Text);


            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Quantità";
            chart1.ChartAreas[0].AxisY.Title = "Prezzo";
            chart1.Titles.Clear();
            chart1.Titles.Add("Domanda e Offerta");

            Series domanda = new Series("Domanda");
            domanda.ChartType = SeriesChartType.Line;
            domanda.Color = Color.Green;
            domanda.BorderWidth = 3;

            Series offerta = new Series("Offerta");
            offerta.ChartType = SeriesChartType.Line;
            offerta.Color = Color.Blue;
            offerta.BorderWidth = 3;

            chart1.Series.Add(domanda);
            chart1.Series.Add(offerta);


            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("q", "Quantità");
            dataGridView1.Columns.Add("d", "Domanda");
            dataGridView1.Columns.Add("o", "Offerta");


            for (int q = 0; q <= 20; q++)
            {
                double d = a - (b * q);
                double o = c + (Math.Pow(q, f) / g);


                domanda.Points.AddXY(q, d);
                offerta.Points.AddXY(q, o);


                dataGridView1.Rows.Add(q, d.ToString("0.00"), o.ToString("0.00"));
            }
        }
    }
}

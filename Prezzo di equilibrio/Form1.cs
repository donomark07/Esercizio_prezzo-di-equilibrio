using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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




        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Titles.Add("Esempio Grafico");

            chart1.Series.Add("Domanda");
            chart1.Series["Domanda"].Color = Color.Green;
            chart1.Series["Domanda"].ChartType = SeriesChartType.Point;

            chart1.Series.Add("Offerta");
            chart1.Series["Offerta"].Color = Color.Blue;
            chart1.Series["Offerta"].ChartType = SeriesChartType.Point;

            chart1.Series["Domanda"].Points.AddXY(1, 40);
            chart1.Series["Domanda"].Points.AddXY(2, 60);
            chart1.Series["Domanda"].Points.AddXY(3, 80);
            chart1.Series["Domanda"].Points.AddXY(4, 100);
            chart1.Series["Offerta"].Points.AddXY(5, 110);
            chart1.Series["Offerta"].Points.AddXY(6, 80);
            chart1.Series["Offerta"].Points.AddXY(7, 70);


            //DOANDA 
            double B2 = 90;  
            double B3 = 4;

            //OFFERTA
            double C1 = 10;     
            double C2 = 0.01;   
            double C3 = 3;

            
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Quantità";
            chart1.ChartAreas[0].AxisY.Title = "Prezzo";
            chart1.Titles.Clear();
            chart1.Titles.Add("Domanda e Offerta - Prezzo di Equilibrio");

        }
    }
}

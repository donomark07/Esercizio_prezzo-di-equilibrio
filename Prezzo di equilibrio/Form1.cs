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
        }
    }
}

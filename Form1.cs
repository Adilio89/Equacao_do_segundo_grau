using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equação_do_segundo_grau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x;
            try
            {
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                delta = Math.Pow(b, 2) - (4 * a * c);
                txtdelta.Text = delta.ToString();
                if (delta < 0)
                {
                    
                }
                else if (delta == 0)
                {
                    x = (-b) / (2 * a);
                    txtx1.Text = x.ToString();
                }
                else
                {
                    x = ((-b) + Math.Sqrt(delta)) / (2 * a);
                    txtx1.Text = x.ToString();
                    x = ((-b) - Math.Sqrt(delta)) / (2 * a);
                    txtx2.Text = x.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Favor verifique os valores digitados");
                txta.Focus();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtdelta.Clear();
            txtx1.Clear();
            txtx2.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

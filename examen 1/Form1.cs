using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_1
{
    public partial class Form1 : Form
    {
        int a ;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b;
            a = a + 1;
            pant.Text = "";
            if (a <= 25)
            {
                for (int i = 1; i <= a; i++)
                {
                    b = i;

                    pant.Text = pant.Text + b + ", ";

                }
            }
        }

        private void x_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b;
            a = a - 1;
            pant.Text = "";
            if (a <= 25)
            {
                for (int i = 1; i <= a; i++)
                {
                    b = i;

                    pant.Text = pant.Text + b + ", ";

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvC
{
    public partial class Form1 : Form
    {
        double n1;
        double n2;
        double result;
        string pro;  

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(lb_res.Text == "00")
            {
                lb_res.Text = "";
                lb_res.Text = lb_res.Text + btn.Text;
            }
            else
            {
                lb_res.Text = lb_res.Text + btn.Text;
            }

            if(lb_cal.Text != "")
            {
                lb_cal.Text = lb_cal.Text + btn.Text;
            }

            else
            {
                lb_cal.Text = lb_res.Text;
            }
        }

        private void pro_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            n1 = Convert.ToDouble(lb_res.Text);
            pro = btn.Text;
            if (lb_cal.Text != "")
            {
                lb_cal.Text = lb_cal.Text + pro;
            }
            else
            {
                lb_cal.Text = lb_res.Text + pro;

            }

            lb_res.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            n2 = Convert.ToDouble(lb_res.Text);
            if (pro == "+")
            {
                result = n1 + n2;
                lb_res.Text = Convert.ToString(result);

            }

            else if (pro == "-")
            {
                result = n1 - n2;
                lb_res.Text = Convert.ToString(result);

            }

            else if (pro == "*")
            {
                result = n1 * n2;
                lb_res.Text = Convert.ToString(result);

            }

            else if (pro == "/")
            {
                result = n1 / n2;
                lb_res.Text = Convert.ToString(result);

            }

           
        }

        private void c_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lb_res.Text = "";
            lb_cal.Text = "";
        }
    }
}

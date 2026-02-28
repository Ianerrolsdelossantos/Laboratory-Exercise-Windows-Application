using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string name = NameBox.Text;

                double eng = Convert.ToDouble(engtxt.Text);
                double math = Convert.ToDouble(mathtxt.Text);
                double sci = Convert.ToDouble(scitxt.Text);
                double fil = Convert.ToDouble(filtxt.Text);
                double his = Convert.ToDouble(histxt.Text);

                double average = (eng + math + sci + fil + his) / 5;

                LBLstatus.Text = (average >= 75.80) ? "The Student passed." : "The Student failed.";
                LblAverage.Text = "The general average of " + NameBox + "is" + average.ToString("F2") + ".";

                try
                {

                }
                catch (FormatException)

                {
                    MessageBox.Show("please enter valid number in all grade fields.");
                }
            }
    }
}

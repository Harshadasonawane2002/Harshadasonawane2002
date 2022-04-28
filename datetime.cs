//Demonstrate use of DateTimePicker
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
publicpartialclassForm1 : Form
    {
public Form1()
        {
            InitializeComponent();
        }

privatevoid dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
int d;
DateTime firstdate = Convert.ToDateTime(dateTimePicker1.Text);
DateTime seconddate = Convert.ToDateTime(dateTimePicker2.Text);
            d = firstdate.Subtract(seconddate).Days;
            textBox1.Text = Math.Abs(d).ToString();

        }

           }
}


 

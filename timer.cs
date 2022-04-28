//demonstration use  of timer control.
using System;
using System.Windows.Forms;

namespace timer
{
publicpartialclassForm1 : Form
    {
int t;
public Form1()
        {

            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

privatevoid timer1_Tick(object sender, EventArgs e)
        {
            t++;
            label1.Text = t.ToString();
if (t == 10)
            {
                timer1.Stop();
                label1.Text = "time out";
            }
        }

privatevoid timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }


    }
}


 

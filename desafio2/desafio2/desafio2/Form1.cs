using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio2
{
    public partial class Form1 : Form
    {
        private int _ticks = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Desligado" && _ticks != 0)
            {
                label1.Text = "Ligado";
                timer1.Start();
            }
            else
            {
                label1.Text = "Desligado";
                timer1.Stop();
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "Ligado" && _ticks != 0)
            {
                _ticks--;
                label2.Text = _ticks.ToString();
            }
            else
            {
                label1.Text = "Desligado";
                timer1.Stop();
            }
        }
    }
}

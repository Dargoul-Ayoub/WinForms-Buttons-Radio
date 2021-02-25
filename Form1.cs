using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons_Radio
{
    public partial class Form1 : Form
    {
        private int i = 0;
        private int j = 0;
        private bool choix1 = false;
        private bool choix2 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // textBox2.Text = "Bouton N°1";
            i = 1;
            choix2 = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "Bouton N°1";
            j = 1;
            choix1 = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //textBox2.Text = "Bouton N°2";
            i = 2;
            choix2 = true;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "Bouton N°2";
            j = 2;
            choix1 = true;


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //textBox2.Text = "Bouton N°3";
            i = 3;
            choix2 = true;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "Bouton N°3";
            j = 3;
            choix1 = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (choix1 && choix2)
            {
                label2.Text = "Button N°" + Convert.ToString(j);
                label1.Text = "Button N°" + Convert.ToString(i);
            }
        }
    }
}

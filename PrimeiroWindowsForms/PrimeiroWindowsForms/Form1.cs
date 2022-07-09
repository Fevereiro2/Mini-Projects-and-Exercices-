using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroWindowsForms
{

    

    public partial class Form1 : Form
    {
        static int cliques;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bconfirmar_Click(object sender, EventArgs e)
        {
            if (TBOX1.Text == "")

            {
                MessageBox.Show("Tens de intruzir nome");
            }
            else
            {
            lvazio.Text = "Olá " +TBOX1.Text+ " !";
            TBOX1.Clear();
            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_Click(object sender, EventArgs e)
        {

        }

        private void bvermelho_Click(object sender, EventArgs e)
        {
            lvazio.BackColor = Color.Red;
            lvazio.ForeColor = Color.White;
        }

        private void bverde_Click(object sender, EventArgs e)
        {
            lvazio.BackColor = Color.Green;
            lvazio.ForeColor = Color.White;
        }

        private void bazul_Click(object sender, EventArgs e)
        {
            lvazio.BackColor = Color.Blue;
            lvazio.ForeColor = Color.White;

            


                cliques++;

                if (cliques == 10)
                {
                    pictureBox1.Visible = true;
                }

            
                


            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
    }
}

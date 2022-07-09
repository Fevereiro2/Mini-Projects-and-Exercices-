using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cartãodoaluno
{
    public partial class Form1 : Form
    {
        static string nome, morada, email;
        static int tel, nascimentoo, idade;
        public Form1()
        {
            InitializeComponent();


            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void l_telefone_Click(object sender, EventArgs e)
        {

        }

        private void l_sexo_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void l_nascimento_Click(object sender, EventArgs e)
        {

        }

        private void tb_nascimento_TextChanged(object sender, EventArgs e)
        {
            nascimentoo = int.Parse(tb_nascimento.Text);
        }

        private void b_editar1_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            tb_nome.ReadOnly = false;
        }

        private void b_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void b_validar_Click(object sender, EventArgs e)
        {

            if (feminino.Checked == true)
            {
                l_resultados.Text = "Olá, o teu nom é " + tb_nome.Text + "\n moras no " + tb_morada.Text + "\n o teu numero de telfone é " + tb_telefone.Text + "\n o teu email é " + tb_email.Text + "\n tu tens " + (2022 - nascimentoo) + " anos porque nasceste em "+ tb_nascimento +"\n e o teu sexo é " + feminino.Name  ;
            }
            else if (masculino.Checked == true)
            {
                l_resultados.Text = "Olá, o teu nom é " + tb_nome.Text + "\n moras no " + tb_morada.Text + "\n o teu numero de telfone é " + tb_telefone.Text + "\n o teu email é " + tb_email.Text + "\n tu tens " + (2022 - nascimentoo ) + " anos porque nasceste em "+ tb_nascimento + "\n e o teu sexo é " +  masculino.Name ;
            }

            
        }

        private void b_editar5_Click(object sender, EventArgs e)
        {
            tb_nascimento.Enabled = true;
            tb_nascimento.ReadOnly = false;
        }

        private void b_editar2_Click(object sender, EventArgs e)
        {
            tb_morada.Enabled = true;
            tb_morada.ReadOnly = false;
        }

        private void b_editar3_Click(object sender, EventArgs e)
        {
            tb_telefone.Enabled = true;
            tb_telefone.ReadOnly = false;
        }

        private void b_editar4_Click(object sender, EventArgs e)
        {
            tb_email.Enabled = true;
            tb_email.ReadOnly = false;
        }

        private void rd_feminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void b_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_morada.Clear();
            tb_email.Clear();
            tb_nascimento.Clear();
            tb_telefone.Clear();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            idade = dateTimePicker1.Value.Year - Convert.ToInt16(tb_nascimento);

        }

        private void tb_morada_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

                



        }
    }
}

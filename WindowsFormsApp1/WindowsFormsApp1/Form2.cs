using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    
    public partial class Form2 : Form
    {
        
        private Point offset;
        Thread nf;
        bool mouseDown;





        public Form2()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            MenusDesign();
            


        }

        private static int dinheiro = 0;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            {
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Minimized;

                }
                else if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            nf = new Thread(casa);
            nf.SetApartmentState(ApartmentState.STA); //unica thread
            nf.Start();
        }

        private void casa()
        {

            Application.Run(new Form1());
            
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseup_event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public static int cont =0;

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (dinheiro <= 0)
            {
                MessageBox.Show("Não tens dinheiro");
            }
            else if (dinheiro >= 1)
            {
                dinheiro -= 5;
                label17.Text = dinheiro + "€";
                int slot1 = 0, slot2 = 0, slot3 = 0, slot4 = 0, slot5 = 0, slot6 = 0, slot7 = 0, slot8 = 0, slot9 = 0, slot10 = 0, slot11 = 0, slot12 = 0, slot13 = 0, slot14 = 0, slot15 = 0;

                Random rnd = new Random();
                cont++;


                if (cont < 9)
                {
                    slot1 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot1 = rnd.Next(1, 13);

                }
                switch (slot1)
                {
                    case 1:
                        pb_1.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_1.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_1.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_1.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_1.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_1.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_1.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_1.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_1.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_1.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_1.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_1.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }


                //compartimento 2

                //int slot2 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot2 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot2 = rnd.Next(1, 13);

                }

                switch (slot2)
                {
                    case 1:
                        pb_2.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_2.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_2.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_2.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_2.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_2.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_2.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_2.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_2.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_2.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_2.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_2.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }


                //compartimento 3
                //slot3 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot3 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot3 = rnd.Next(1, 13);

                }
                switch (slot3)
                {
                    case 1:
                        pb_3.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_3.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_3.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_3.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_3.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_3.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_3.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_3.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_3.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_3.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_3.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_3.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }

                //compartimento 4

                //slot4 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot4 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot4 = rnd.Next(1, 13);

                }
                switch (slot4)
                {
                    case 1:
                        pb_4.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_4.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_4.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_4.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_4.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_4.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_4.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_4.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_4.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_4.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_4.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_4.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }
                //compartimento 5

                //slot5 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot5 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot5 = rnd.Next(1, 13);

                }
                switch (slot5)
                {
                    case 1:
                        pb_5.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_5.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_5.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_5.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_5.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_5.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_5.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_5.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_5.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_5.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_5.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_5.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }
                //compartimento 6
                //slot6 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot6 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot6 = rnd.Next(1, 13);

                }
                switch (slot6)
                {
                    case 1:
                        pb_6.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_6.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_6.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_6.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_6.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_6.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_6.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_6.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_6.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_6.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_6.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_6.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }
                //compartimento 7
                //slot7 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot7 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot7 = rnd.Next(1, 13);

                }
                switch (slot7)
                {
                    case 1:
                        pb_7.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_7.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_7.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_7.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_7.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_7.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_7.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_7.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_7.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_7.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_7.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_7.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }

                //compartimento 8

                //slot8 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot8 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot8 = rnd.Next(1, 13);

                }
                switch (slot8)
                {
                    case 1:
                        pb_8.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_8.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_8.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_8.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_8.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_8.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_8.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_8.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_8.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_8.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_8.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_8.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }
                //compartimento 9

                //slot9 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot9 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot9 = rnd.Next(1, 13);

                }
                switch (slot9)
                {
                    case 1:
                        pb_9.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_9.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_9.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_9.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_9.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_9.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_9.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_9.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_9.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_9.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_9.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_9.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }

                //compartimento 10

                //slot10 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot10 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot10 = rnd.Next(1, 13);

                }
                switch (slot10)
                {
                    case 1:
                        pb_10.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_10.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_10.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_10.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_10.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_10.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_10.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_10.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_10.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_10.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_10.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_10.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }
                //compartimento 11

                //slot11 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot11 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot11 = rnd.Next(1, 13);

                }
                switch (slot11)
                {
                    case 1:
                        pb_11.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_11.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_11.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_11.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_11.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_11.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_11.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_11.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_11.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_11.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_11.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_11.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }
                //compartimento 12

                //slot12 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot12 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot12 = rnd.Next(1, 13);

                }
                switch (slot12)
                {
                    case 1:
                        pb_12.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_12.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_12.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_12.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_12.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_12.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_12.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_12.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_12.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_12.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_12.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_12.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }

                //compartimento 13

                //slot13 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot13 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot13 = rnd.Next(1, 13);

                }
                switch (slot13)
                {
                    case 1:
                        pb_13.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_13.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_13.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_13.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_13.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_13.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_13.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_13.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_13.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_13.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_13.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_13.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }
                //compartimento 14

                //slot14 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot14 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot14 = rnd.Next(1, 13);

                }
                switch (slot14)
                {
                    case 1:
                        pb_14.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_14.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_14.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_14.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_14.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_14.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_14.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_14.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_14.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_14.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_14.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_14.Image = Properties.Resources.fevereiro; //bonus
                        break;
                }
                //compartimento 15

                //slot15 = rnd.Next(1, 13);
                cont++;


                if (cont < 9)
                {
                    slot15 = rnd.Next(1, 10);
                }
                if (cont >= 10 && cont <= 15)
                {
                    //MessageBox.Show("Teste");
                    cont = 0;
                    slot15 = rnd.Next(1, 13);

                }
                switch (slot15)
                {
                    case 1:
                        pb_15.Image = Properties.Resources.jota;
                        break;
                    case 2:
                        pb_15.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_15.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_15.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_15.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_15.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_15.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_15.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_15.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_15.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_15.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_15.Image = Properties.Resources.fevereiro; //bonus
                        break;


                }
                if (slot1 == 1 && slot2 == 1 && slot3 == 1 && slot4 == 1 && slot5 == 1)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de jotas");
                }
                else if (slot1 == 2 && slot2 == 2 && slot3 == 2 && slot4 == 2 && slot5 == 2)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de dama");
                }
                else if (slot1 == 3 && slot2 == 3 && slot3 == 3 && slot4 == 3 && slot5 == 3)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de Kapa");
                }
                else if (slot1 == 4 && slot2 == 4 && slot3 == 4 && slot4 == 4 && slot5 == 4)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de cerejas");
                }
                else if (slot1 == 5 && slot2 == 5 && slot3 == 5 && slot4 == 5 && slot5 == 5)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de as");
                }
                else if (slot1 == 6 && slot2 == 6 && slot3 == 6 && slot4 == 6 && slot5 == 6)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de diamante");
                }
                else if (slot1 == 7 && slot2 == 7 && slot3 == 7 && slot4 == 7 && slot5 == 7)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de estrela");
                }
                else if (slot1 == 8 && slot2 == 8 && slot3 == 8 && slot4 == 8 && slot5 == 8)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de ferradura");
                }
                else if (slot1 == 9 && slot2 == 9 && slot3 == 9 && slot4 == 9 && slot5 == 9)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de sino");
                }
                else if (slot1 == 10 && slot2 == 10 && slot3 == 10 && slot4 == 10 && slot5 == 10)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de setes");
                }
                else if (slot1 == 11 && slot2 == 11 && slot3 == 11 && slot4 == 11 && slot5 == 11)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de limão");
                }
                else if (slot1 == 12 && slot2 == 12 && slot3 == 12 && slot4 == 12 && slot5 == 12)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de fevereiro");
                }



                if (slot6 == 1 && slot7 == 1 && slot8 == 1 && slot9 == 1 && slot10 == 1)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de jotas");
                }
                else if (slot6 == 2 && slot7 == 2 && slot8 == 2 && slot9 == 2 && slot10 == 2)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de dama");
                }
                else if (slot6 == 3 && slot7 == 3 && slot8 == 3 && slot9 == 3 && slot10 == 3)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de Kapa");
                }
                else if (slot6 == 4 && slot7 == 4 && slot8 == 4 && slot9 == 4 && slot10 == 4)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de cerejas");
                }
                else if (slot6 == 5 && slot7 == 5 && slot8 == 5 && slot9 == 5 && slot10 == 5)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de as");
                }
                else if (slot6 == 6 && slot7 == 6 && slot8 == 6 && slot9 == 6 && slot10 == 6)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de diamante");
                }
                else if (slot6 == 7 && slot7 == 7 && slot8 == 7 && slot9 == 7 && slot10 == 7)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de estrela");
                }
                else if (slot6 == 8 && slot7 == 8 && slot8 == 8 && slot9 == 8 && slot10 == 8)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de ferradura");
                }
                else if (slot6 == 9 && slot7 == 9 && slot8 == 9 && slot9 == 9 && slot10 == 9)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de sino");
                }
                else if (slot6 == 10 && slot7 == 10 && slot8 == 10 && slot9 == 10 && slot10 == 10)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de setes");
                }
                else if (slot6 == 11 && slot7 == 11 && slot8 == 11 && slot9 == 11 && slot10 == 11)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de limão");
                }
                else if (slot6 == 12 && slot7 == 12 && slot8 == 12 && slot9 == 12 && slot10 == 12)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de fevereiro");
                }



                if (slot11 == 1 && slot12 == 1 && slot13 == 1 && slot14 == 1 && slot15 == 1)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de jotas");
                }
                else if (slot11 == 2 && slot12 == 2 && slot13 == 2 && slot14 == 2 && slot15 == 2)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de dama");
                }
                else if (slot11 == 3 && slot12 == 3 && slot13 == 3 && slot14 == 3 && slot15 == 3)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de Kapa");
                }
                else if (slot11 == 4 && slot12 == 4 && slot13 == 4 && slot14 == 4 && slot15 == 4)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de cerejas");
                }
                else if (slot11 == 5 && slot12 == 5 && slot13 == 5 && slot14 == 5 && slot15 == 5)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de as");
                }
                else if (slot11 == 6 && slot12 == 6 && slot13 == 6 && slot14 == 6 && slot15 == 6)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de diamante");
                }
                else if (slot11 == 7 && slot12 == 7 && slot13 == 7 && slot14 == 7 && slot15 == 7)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de estrela");
                }
                else if (slot11 == 8 && slot12 == 8 && slot13 == 8 && slot14 == 8 && slot15 == 8)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de ferradura");
                }
                else if (slot11 == 9 && slot12 == 9 && slot13 == 9 && slot14 == 9 && slot15 == 9)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de sino");
                }
                else if (slot11 == 10 && slot12 == 10 && slot13 == 10 && slot14 == 10 && slot15 == 10)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de setes");
                }
                else if (slot11 == 11 && slot12 == 11 && slot13 == 11 && slot14 == 11 && slot15 == 11)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de limão");
                }
                else if (slot11 == 12 && slot12 == 12 && slot13 == 12 && slot14 == 12 && slot15 == 12)
                {
                    dinheiro += 10005;
                    MessageBox.Show("Premiado full-line em cima de fevereiro");
                }


                ///////////////////////////////////////////////////////////////////////
                ///                            4 simbols                            ///
                ///////////////////////////////////////////////////////////////////////

                if (slot1 == 1 && slot2 == 1 && slot3 == 1 && slot4 == 1)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de jotas");
                }
                else if (slot1 == 2 && slot2 == 2 && slot3 == 2 && slot4 == 2)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de dama");
                }
                else if (slot1 == 3 && slot2 == 3 && slot3 == 3 && slot4 == 3)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de Kapa");
                }
                else if (slot1 == 4 && slot2 == 4 && slot3 == 4 && slot4 == 4)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de cerejas");
                }
                else if (slot1 == 5 && slot2 == 5 && slot3 == 5 && slot4 == 5)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de as");
                }
                else if (slot1 == 6 && slot2 == 6 && slot3 == 6 && slot4 == 6)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de diamante");
                }
                else if (slot1 == 7 && slot2 == 7 && slot3 == 7 && slot4 == 7)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de estrela");
                }
                else if (slot1 == 8 && slot2 == 8 && slot3 == 8 && slot4 == 8)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de ferradura");
                }
                else if (slot1 == 9 && slot2 == 9 && slot3 == 9 && slot4 == 9)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de sino");
                }
                else if (slot1 == 10 && slot2 == 10 && slot3 == 10 && slot4 == 10)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de setes");
                }
                else if (slot1 == 11 && slot2 == 11 && slot3 == 11 && slot4 == 11)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de limão");
                }
                else if (slot1 == 12 && slot2 == 12 && slot3 == 12 && slot4 == 12)
                {
                    dinheiro += 1005;
                    MessageBox.Show("Premiado 4x em cima de fevereiro");
                }



                if (slot6 == 1 && slot7 == 1 && slot8 == 1 && slot9 == 1)
                {
                    MessageBox.Show("Premiado 4x em cima de jotas");
                }
                else if (slot6 == 2 && slot7 == 2 && slot8 == 2 && slot9 == 2)
                {
                    MessageBox.Show("Premiado 4x em cima de dama");
                }
                else if (slot6 == 3 && slot7 == 3 && slot8 == 3 && slot9 == 3)
                {
                    MessageBox.Show("Premiado 4x em cima de Kapa");
                }
                else if (slot6 == 4 && slot7 == 4 && slot8 == 4 && slot9 == 4)
                {
                    MessageBox.Show("Premiado 4x em cima de cerejas");
                }
                else if (slot6 == 5 && slot7 == 5 && slot8 == 5 && slot9 == 5)
                {
                    MessageBox.Show("Premiado 4x em cima de as");
                }
                else if (slot6 == 6 && slot7 == 6 && slot8 == 6 && slot9 == 6)
                {
                    MessageBox.Show("Premiado 4x em cima de diamante");
                }
                else if (slot6 == 7 && slot7 == 7 && slot8 == 7 && slot9 == 7)
                {
                    MessageBox.Show("Premiado 4x em cima de estrela");
                }
                else if (slot6 == 8 && slot7 == 8 && slot8 == 8 && slot9 == 8)
                {
                    MessageBox.Show("Premiado 4x em cima de ferradura");
                }
                else if (slot6 == 9 && slot7 == 9 && slot8 == 9 && slot9 == 9)
                {
                    MessageBox.Show("Premiado 4x em cima de sino");
                }
                else if (slot6 == 10 && slot7 == 10 && slot8 == 10 && slot9 == 10)
                {
                    MessageBox.Show("Premiado 4x em cima de setes");
                }
                else if (slot6 == 11 && slot7 == 11 && slot8 == 11 && slot9 == 11)
                {
                    MessageBox.Show("Premiado 4x em cima de limão");
                }
                else if (slot6 == 12 && slot7 == 12 && slot8 == 12 && slot9 == 12)
                {
                    MessageBox.Show("Premiado 4x em cima de fevereiro");
                }



                if (slot11 == 1 && slot12 == 1 && slot13 == 1 && slot14 == 1)
                {
                    MessageBox.Show("Premiado 4x em cima de jotas");
                }
                else if (slot11 == 2 && slot12 == 2 && slot13 == 2 && slot14 == 2)
                {
                    MessageBox.Show("Premiado 4x em cima de dama");
                }
                else if (slot11 == 3 && slot12 == 3 && slot13 == 3 && slot14 == 3)
                {
                    MessageBox.Show("Premiado 4x em cima de Kapa");
                }
                else if (slot11 == 4 && slot12 == 4 && slot13 == 4 && slot14 == 4)
                {
                    MessageBox.Show("Premiado 4x em cima de cerejas");
                }
                else if (slot11 == 5 && slot12 == 5 && slot13 == 5 && slot14 == 5)
                {
                    MessageBox.Show("Premiado 4x em cima de as");
                }
                else if (slot11 == 6 && slot12 == 6 && slot13 == 6 && slot14 == 6)
                {
                    MessageBox.Show("Premiado 4x em cima de diamante");
                }
                else if (slot11 == 7 && slot12 == 7 && slot13 == 7 && slot14 == 7)
                {
                    MessageBox.Show("Premiado 4x em cima de estrela");
                }
                else if (slot11 == 8 && slot12 == 8 && slot13 == 8 && slot14 == 8)
                {
                    MessageBox.Show("Premiado 4x em cima de ferradura");
                }
                else if (slot11 == 9 && slot12 == 9 && slot13 == 9 && slot14 == 9)
                {
                    MessageBox.Show("Premiado 4x em cima de sino");
                }
                else if (slot11 == 10 && slot12 == 10 && slot13 == 10 && slot14 == 10)
                {
                    MessageBox.Show("Premiado 4x em cima de setes");
                }
                else if (slot11 == 11 && slot12 == 11 && slot13 == 11 && slot14 == 11)
                {
                    MessageBox.Show("Premiado 4x em cima de limão");
                }
                else if (slot11 == 12 && slot12 == 12 && slot13 == 12 && slot14 == 12)
                {
                    MessageBox.Show("Premiado 4x em cima de fevereiro");
                }


                ///////////////////////////////////////////////////////////////////////
                ///                            3 simbols                            ///
                ///////////////////////////////////////////////////////////////////////

                if (slot1 == 1 && slot2 == 1 && slot3 == 1)
                {
                    MessageBox.Show("Premiado 3x em cima de jotas");
                }
                else if (slot1 == 2 && slot2 == 2 && slot3 == 2)
                {
                    MessageBox.Show("Premiado 3x em cima de dama");
                }
                else if (slot1 == 3 && slot2 == 3 && slot3 == 3)
                {
                    MessageBox.Show("Premiado 3x em cima de Kapa");
                }
                else if (slot1 == 4 && slot2 == 4 && slot3 == 4)
                {
                    MessageBox.Show("Premiado 3x em cima de cerejas");
                }
                else if (slot1 == 5 && slot2 == 5 && slot3 == 5)
                {
                    MessageBox.Show("Premiado 3x em cima de as");
                }
                else if (slot1 == 6 && slot2 == 6 && slot3 == 6)
                {
                    MessageBox.Show("Premiado 3x em cima de diamante");
                }
                else if (slot1 == 7 && slot2 == 7 && slot3 == 7)
                {
                    MessageBox.Show("Premiado 3x em cima de estrela");
                }
                else if (slot1 == 8 && slot2 == 8 && slot3 == 8)
                {
                    MessageBox.Show("Premiado 3x em cima de ferradura");
                }
                else if (slot1 == 9 && slot2 == 9 && slot3 == 9)
                {
                    MessageBox.Show("Premiado 3x em cima de sino");
                }
                else if (slot1 == 10 && slot2 == 10 && slot3 == 10)
                {
                    MessageBox.Show("Premiado 3x em cima de setes");
                }
                else if (slot1 == 11 && slot2 == 11 && slot3 == 11)
                {
                    MessageBox.Show("Premiado 3x em cima de limão");
                }
                else if (slot1 == 12 && slot2 == 12 && slot3 == 12)
                {
                    MessageBox.Show("Premiado 3x em cima de fevereiro");
                }



                if (slot6 == 1 && slot7 == 1 && slot8 == 1)
                {
                    MessageBox.Show("Premiado 3x em cima de jotas");
                }
                else if (slot6 == 2 && slot7 == 2 && slot8 == 2)
                {
                    MessageBox.Show("Premiado 3x em cima de dama");
                }
                else if (slot6 == 3 && slot7 == 3 && slot8 == 3)
                {
                    MessageBox.Show("Premiado 3x em cima de Kapa");
                }
                else if (slot6 == 4 && slot7 == 4 && slot8 == 4)
                {
                    MessageBox.Show("Premiado 3x em cima de cerejas");
                }
                else if (slot6 == 5 && slot7 == 5 && slot8 == 5)
                {
                    MessageBox.Show("Premiado 3x em cima de as");
                }
                else if (slot6 == 6 && slot7 == 6 && slot8 == 6)
                {
                    MessageBox.Show("Premiado 3x em cima de diamante");
                }
                else if (slot6 == 7 && slot7 == 7 && slot8 == 7)
                {
                    MessageBox.Show("Premiado 3x em cima de estrela");
                }
                else if (slot6 == 8 && slot7 == 8 && slot8 == 8)
                {
                    MessageBox.Show("Premiado 3x em cima de ferradura");
                }
                else if (slot6 == 9 && slot7 == 9 && slot8 == 9)
                {
                    MessageBox.Show("Premiado 3x em cima de sino");
                }
                else if (slot6 == 10 && slot7 == 10 && slot8 == 10)
                {
                    MessageBox.Show("Premiado 3x em cima de setes");
                }
                else if (slot6 == 11 && slot7 == 11 && slot8 == 11)
                {
                    MessageBox.Show("Premiado 3x em cima de limão");
                }
                else if (slot6 == 12 && slot7 == 12 && slot8 == 12)
                {
                    MessageBox.Show("Premiado 3x em cima de fevereiro");
                }



                if (slot11 == 1 && slot12 == 1 && slot13 == 1)
                {
                    MessageBox.Show("Premiado 3x em cima de jotas");
                }
                else if (slot11 == 2 && slot12 == 2 && slot13 == 2)
                {
                    MessageBox.Show("Premiado 3x em cima de dama");
                }
                else if (slot11 == 3 && slot12 == 3 && slot13 == 3)
                {
                    MessageBox.Show("Premiado 3x em cima de Kapa");
                }
                else if (slot11 == 4 && slot12 == 4 && slot13 == 4)
                {
                    MessageBox.Show("Premiado 3x em cima de cerejas");
                }
                else if (slot11 == 5 && slot12 == 5 && slot13 == 5)
                {
                    MessageBox.Show("Premiado 3x em cima de as");
                }
                else if (slot11 == 6 && slot12 == 6 && slot13 == 6)
                {
                    MessageBox.Show("Premiado 3x em cima de diamante");
                }
                else if (slot11 == 7 && slot12 == 7 && slot13 == 7)
                {
                    MessageBox.Show("Premiado 3x em cima de estrela");
                }
                else if (slot11 == 8 && slot12 == 8 && slot13 == 8)
                {
                    MessageBox.Show("Premiado 3x em cima de ferradura");
                }
                else if (slot11 == 9 && slot12 == 9 && slot13 == 9)
                {
                    MessageBox.Show("Premiado 3x em cima de sino");
                }
                else if (slot11 == 10 && slot12 == 10 && slot13 == 10)
                {
                    MessageBox.Show("Premiado 3x em cima de setes");
                }
                else if (slot11 == 11 && slot12 == 11 && slot13 == 11)
                {
                    MessageBox.Show("Premiado 3x em cima de limão");
                }
                else if (slot11 == 12 && slot12 == 12 && slot13 == 12)
                {
                    MessageBox.Show("Premiado 3x em cima de fevereiro");
                }

                ///////////////////////////////////////////////////////////////////////
                ///                                                                 ///
                ///            *   *                                                ///
                ///             * *         5x                                      ///                                                                
                ///              *                                                  ///                                                                
                ///                                                                 ///                                                                
                ///////////////////////////////////////////////////////////////////////

                if (slot1 == 1 && slot7 == 1 && slot13 == 1 && slot9 == 1 && slot5 == 1)
                {
                    MessageBox.Show("Premiado full-line em cima de jotas em v ");
                }
                else if (slot1 == 2 && slot7 == 2 && slot13 == 2 && slot9 == 2 && slot5 == 2)
                {
                    MessageBox.Show("Premiado full-line em cima de dama em v");
                }
                else if (slot1 == 3 && slot7 == 3 && slot13 == 3 && slot9 == 3 && slot5 == 3)
                {
                    MessageBox.Show("Premiado full-line em cima de Kapa em v");
                }
                else if (slot1 == 4 && slot7 == 4 && slot13 == 4 && slot9 == 4 && slot5 == 4)
                {
                    MessageBox.Show("Premiado full-line em cima de cerejas em v");
                }
                else if (slot1 == 5 && slot7 == 5 && slot13 == 5 && slot9 == 5 && slot5 == 5)
                {
                    MessageBox.Show("Premiado full-line em cima de as em v");
                }
                else if (slot1 == 6 && slot7 == 6 && slot13 == 6 && slot9 == 6 && slot5 == 6)
                {
                    MessageBox.Show("Premiado full-line em cima de diamante em v");
                }
                else if (slot1 == 7 && slot7 == 7 && slot13 == 7 && slot9 == 7 && slot5 == 7)
                {
                    MessageBox.Show("Premiado full-line em cima de estrela em v");
                }
                else if (slot1 == 8 && slot7 == 8 && slot13 == 8 && slot9 == 8 && slot5 == 8)
                {
                    MessageBox.Show("Premiado full-line em cima de ferradura em v");
                }
                else if (slot1 == 9 && slot7 == 9 && slot13 == 9 && slot9 == 9 && slot5 == 9)
                {
                    MessageBox.Show("Premiado full-line em cima de sino em v");
                }
                else if (slot1 == 10 && slot7 == 10 && slot13 == 10 && slot9 == 10 && slot5 == 10)
                {
                    MessageBox.Show("Premiado full-line em cima de setes em v");
                }
                else if (slot1 == 11 && slot7 == 11 && slot13 == 11 && slot9 == 11 && slot5 == 11)
                {
                    MessageBox.Show("Premiado full-line em cima de limão em v");
                }
                else if (slot1 == 12 && slot7 == 12 && slot13 == 12 && slot9 == 12 && slot5 == 12)
                {
                    MessageBox.Show("Premiado full-line em cima de fevereiro em v");
                }

                ///////////////////////////////////////////////////////////////////////
                ///                                                                 ///
                ///            *   *                                                ///
                ///             * *         4x                                      ///                                                                
                ///              *                                                  ///                                                                
                ///                                                                 ///                                                                
                ///////////////////////////////////////////////////////////////////////

                if (slot1 == 1 && slot7 == 1 && slot13 == 1 && slot9 == 1)
                {
                    MessageBox.Show("Premiado 4x em cima de jotas em v ");
                }
                else if (slot1 == 2 && slot7 == 2 && slot13 == 2 && slot9 == 2)
                {
                    MessageBox.Show("Premiado 4x em cima de dama em v");
                }
                else if (slot1 == 3 && slot7 == 3 && slot13 == 3 && slot9 == 3)
                {
                    MessageBox.Show("Premiado 4x em cima de Kapa em v");
                }
                else if (slot1 == 4 && slot7 == 4 && slot13 == 4 && slot9 == 4)
                {
                    MessageBox.Show("Premiado 4x em cima de cerejas em v");
                }
                else if (slot1 == 5 && slot7 == 5 && slot13 == 5 && slot9 == 5)
                {
                    MessageBox.Show("Premiado 4x em cima de as em v");
                }
                else if (slot1 == 6 && slot7 == 6 && slot13 == 6 && slot9 == 6)
                {
                    MessageBox.Show("Premiado 4x em cima de diamante em v");
                }
                else if (slot1 == 7 && slot7 == 7 && slot13 == 7 && slot9 == 7)
                {
                    MessageBox.Show("Premiado 4x em cima de estrela em v");
                }
                else if (slot1 == 8 && slot7 == 8 && slot13 == 8 && slot9 == 8)
                {
                    MessageBox.Show("Premiado 4x em cima de ferradura em v");
                }
                else if (slot1 == 9 && slot7 == 9 && slot13 == 9 && slot9 == 9)
                {
                    MessageBox.Show("Premiado 4x em cima de sino em v");
                }
                else if (slot1 == 10 && slot7 == 10 && slot13 == 10 && slot9 == 10)
                {
                    MessageBox.Show("Premiado 4x em cima de setes em v");
                }
                else if (slot1 == 11 && slot7 == 11 && slot13 == 11 && slot9 == 11)
                {
                    MessageBox.Show("Premiado 4x em cima de limão em v");
                }
                else if (slot1 == 12 && slot7 == 12 && slot13 == 12 && slot9 == 12)
                {
                    MessageBox.Show("Premiado 4x em cima de fevereiro em v");
                }
                ///////////////////////////////////////////////////////////////////////
                ///                                                                 ///
                ///            *   *                                                ///
                ///             * *         3x                                      ///                                                                
                ///              *                                                  ///                                                                
                ///                                                                 ///                                                                
                ///////////////////////////////////////////////////////////////////////

                if (slot1 == 1 && slot7 == 1 && slot13 == 1)
                {
                    MessageBox.Show("Premiado 3x em cima de jotas em v ");
                }
                else if (slot1 == 2 && slot7 == 2 && slot13 == 2)
                {
                    MessageBox.Show("Premiado 3x em cima de dama em v");
                }
                else if (slot1 == 3 && slot7 == 3 && slot13 == 3)
                {
                    MessageBox.Show("Premiado 3x em cima de Kapa em v");
                }
                else if (slot1 == 4 && slot7 == 4 && slot13 == 4)
                {
                    MessageBox.Show("Premiado 3x em cima de cerejas em v");
                }
                else if (slot1 == 5 && slot7 == 5 && slot13 == 5)
                {
                    MessageBox.Show("Premiado 3x em cima de as em v");
                }
                else if (slot1 == 6 && slot7 == 6 && slot13 == 6)
                {
                    MessageBox.Show("Premiado 3x em cima de diamante em v");
                }
                else if (slot1 == 7 && slot7 == 7 && slot13 == 7)
                {
                    MessageBox.Show("Premiado 3x em cima de estrela em v");
                }
                else if (slot1 == 8 && slot7 == 8 && slot13 == 8)
                {
                    MessageBox.Show("Premiado 3x em cima de ferradura em v");
                }
                else if (slot1 == 9 && slot7 == 9 && slot13 == 9)
                {
                    MessageBox.Show("Premiado 3x em cima de sino em v");
                }
                else if (slot1 == 10 && slot7 == 10 && slot13 == 10)
                {
                    MessageBox.Show("Premiado 3x em cima de setes em v");
                }
                else if (slot1 == 11 && slot7 == 11 && slot13 == 11)
                {
                    MessageBox.Show("Premiado 3x em cima de limão em v");
                }
                else if (slot1 == 12 && slot7 == 12 && slot13 == 12)
                {
                    MessageBox.Show("Premiado 3x em cima de fevereiro em v");











                }
                if (slot1 == 1 && slot7 == 1 && slot13 == 1 && slot9 == 1 && slot5 == 1)
                {
                    MessageBox.Show("Premiado full-line em cima de jotas em v ");
                }
                else if (slot1 == 2 && slot7 == 2 && slot13 == 2 && slot9 == 2 && slot5 == 2)
                {
                    MessageBox.Show("Premiado full-line em cima de dama em v");
                }
                else if (slot1 == 3 && slot7 == 3 && slot13 == 3 && slot9 == 3 && slot5 == 3)
                {
                    MessageBox.Show("Premiado full-line em cima de Kapa em v");
                }
                else if (slot1 == 4 && slot7 == 4 && slot13 == 4 && slot9 == 4 && slot5 == 4)
                {
                    MessageBox.Show("Premiado full-line em cima de cerejas em v");
                }
                else if (slot1 == 5 && slot7 == 5 && slot13 == 5 && slot9 == 5 && slot5 == 5)
                {
                    MessageBox.Show("Premiado full-line em cima de as em v");
                }
                else if (slot1 == 6 && slot7 == 6 && slot13 == 6 && slot9 == 6 && slot5 == 6)
                {
                    MessageBox.Show("Premiado full-line em cima de diamante em v");
                }
                else if (slot1 == 7 && slot7 == 7 && slot13 == 7 && slot9 == 7 && slot5 == 7)
                {
                    MessageBox.Show("Premiado full-line em cima de estrela em v");
                }
                else if (slot1 == 8 && slot7 == 8 && slot13 == 8 && slot9 == 8 && slot5 == 8)
                {
                    MessageBox.Show("Premiado full-line em cima de ferradura em v");
                }
                else if (slot1 == 9 && slot7 == 9 && slot13 == 9 && slot9 == 9 && slot5 == 9)
                {
                    MessageBox.Show("Premiado full-line em cima de sino em v");
                }
                else if (slot1 == 10 && slot7 == 10 && slot13 == 10 && slot9 == 10 && slot5 == 10)
                {
                    MessageBox.Show("Premiado full-line em cima de setes em v");
                }
                else if (slot1 == 11 && slot7 == 11 && slot13 == 11 && slot9 == 11 && slot5 == 11)
                {
                    MessageBox.Show("Premiado full-line em cima de limão em v");
                }
                else if (slot1 == 12 && slot7 == 12 && slot13 == 12 && slot9 == 12 && slot5 == 12)
                {
                    MessageBox.Show("Premiado full-line em cima de fevereiro em v");
                }
            }
        }



            

            

            /*
            if(slot1 == slot2 && slot1 == slot3 && slot1 == slot4 && slot1 == slot5)
            {
                switch (slot1)
                {
                    case 1:
                        MessageBox.Show("Premiado full-line em cima de jotas");
                        break;
                    case 2:
                        pb_15.Image = Properties.Resources.dama;
                        break;
                    case 3:
                        pb_15.Image = Properties.Resources.kapa;
                        break;
                    case 4:
                        pb_15.Image = Properties.Resources.cerejas;
                        break;
                    case 5:
                        pb_15.Image = Properties.Resources.ast;
                        break;
                    case 6:
                        pb_15.Image = Properties.Resources.diamante;
                        break;
                    case 7:
                        pb_15.Image = Properties.Resources.estrela;
                        break;
                    case 8:
                        pb_15.Image = Properties.Resources.ferradura;
                        break;
                    case 9:
                        pb_15.Image = Properties.Resources.sino;
                        break;
                    case 10:
                        pb_15.Image = Properties.Resources.setes;
                        break;
                    case 11:
                        pb_15.Image = Properties.Resources.limão; //wilds
                        break;
                    case 12:
                        pb_15.Image = Properties.Resources.fevereiro; //bonus
                        break;


                }
            }*/


            ///////////////////////////////////////////////////////////////////////
            ///                            5 simbols                            ///
            ///////////////////////////////////////////////////////////////////////

            







        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void customDesign()
        {
            panel5.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel5.Visible == true)
                panel5.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
        public static int f = 0;
        private void guna2Button5_Click(object sender, EventArgs e)
        {

            //+

            
            /*
            
            for (int i = 0; i >= f; i++)
            {
                if (f == 0)
                {
                    f++;
                    MessageBox.Show("olá  " + f);
                }
                else if (f == 1)

                {
                    f++;
                    label6.Text = "2€";
                }
                else if (f == 2)
                {
                    f++;

                    label6.Text = "3€";
                }
                else if (f == 3)
                {
                    f++;

                    label6.Text = "4€";
                }
                else if (f == 3)
                {
                    f++;

                    label6.Text = "5€";
                }
                else if (f == 4)
                {
                    f++;

                    label6.Text = "10€";
                }
                else if (f == 5)
                {
                    f++;

                    label6.Text = "15€";
                }
                else if (f == 6)
                {
                    f++;

                    label6.Text = "20€";
                }
                else if (f == 7)
                {
                    f++;

                    label6.Text = "25€";
                }
                else if (f == 8)
                {
                    f++;

                    label6.Text = "35€";
                }
                else if (f == 9)
                {
                    f++;

                    label6.Text = "40€";
                }
                else if (f == 10)
                {
                    f++;

                    label6.Text = "50€";
                }
                else if (f >= 11 )
                {
                    MessageBox.Show("Não é permitido nenhum valor superior");
                    
                }

            }*/

            f++;
            /*
            switch(f)
            {
                case 0:
                    label6.Text = "1€";
                    break;
                case 1:
                    label6.Text = "2€";
                    break;
                case 2:
                    label6.Text = "3€";
                    break;
                case 3:
                    label6.Text = "5€";
                    break;
                case 4:
                    label6.Text = "10€";
                    break;
                case 5:
                    label6.Text = "15€";
                    break;
                case 6:
                    label6.Text = "20€";
                    break;
                case 7:
                    label6.Text = "30€";
                    break;
                case 8:
                    label6.Text = "50€";
                    break;
                case 9:
                    label6.Text = "All-in";
                    break;
            }
            */

            if(f < -5)
            {
                f = -5;
            }

            if (f == -5)
            {
                label6.Text = "0.20€";
            }
            if (f == -4)
            {
                label6.Text = "0.40€";
            }
            if (f == -3)
            {
                label6.Text = "0.50€";
            }
            if (f == -2)
            {
                label6.Text = "0.60€";
            }
            if (f == -1)
            {
                label6.Text = "0.80€";
            }
            if (f == 0)
            {
                label6.Text = "1€";
            }
            if (f == 1)
            {
                label6.Text = "2€";
            }
            if (f == 2)
            {
                label6.Text = "3€";
            }
            if (f == 3)
            {
                label6.Text = "4€";
            }
            if (f == 4)
            {
                label6.Text = "5€";
            }
            if (f == 5)
            {
                label6.Text = "10€";
            }
            if (f == 6)
            {
                label6.Text = "15€";
            }
            if (f == 7)
            {
                label6.Text = "20€";
            }
            if (f == 8)
            {
                label6.Text = "30€";
            }
            if (f == 9)
            {
                label6.Text = "40€";
            }
            if (f == 10)
            {
                label6.Text = "50€";
            }
            if (f == 11)
            {
                label6.Text = "All-in";
            }

            if (f > 11)
            {
                f = 11;
            }



        }

        

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            //-

            f--;
            if (f < -5)
            {
                f = -5;
            }

            if (f == -5)
            {
                label6.Text = "0.20€";
            }
            if (f == -4)
            {
                label6.Text = "0.40€";
            }
            if (f == -3)
            {
                label6.Text = "0.50€";
            }
            if (f == -2)
            {
                label6.Text = "0.60€";
            }
            if (f == -1)
            {
                label6.Text = "0.80€";
            }
            if (f == 0)
            {
                label6.Text = "1€";
            }
            if (f == 1)
            {
                label6.Text = "2€";
            }
            if (f == 2)
            {
                label6.Text = "3€";
            }
            if (f == 3)
            {
                label6.Text = "4€";
            }
            if (f == 4)
            {
                label6.Text = "5€";
            }
            if (f == 5)
            {
                label6.Text = "10€";
            }
            if (f == 6)
            {
                label6.Text = "15€";
            }
            if (f == 7)
            {
                label6.Text = "20€";
            }
            if (f == 8)
            {
                label6.Text = "30€";
            }
            if (f == 9)
            {
                label6.Text = "40€";
            }
            if (f == 10)
            {
                label6.Text = "50€";
            }
            if (f == 11)
            {
                label6.Text = "All-in";
            }

            if (f > 11)
            {
                f = 11;
            }
            /*
            switch (f)
            {
                case 0:
                    label6.Text = "1€";
                    break;
                case 1:
                    label6.Text = "2€";
                    break;
                case 2:
                    label6.Text = "3€";
                    break;
                case 3:
                    label6.Text = "5€";
                    break;
                case 4:
                    label6.Text = "10€";
                    break;
                case 5:
                    label6.Text = "15€";
                    break;
                case 6:
                    label6.Text = "20€";
                    break;
                case 7:
                    label6.Text = "30€";
                    break;
                case 8:
                    label6.Text = "50€";
                    break;
                case 9:
                    label6.Text = "All-in";
                    break;

            }



            
            for (int i = 0; i < f; i++)
            {
                if ( f == 0)
                {
                    f++;
                    MessageBox.Show("olá  " + f);
                }
                else if (f == 1) 
                   
                {
                    f++;
                    label6.Text = "2€";
                }
                else if (f == 2)
                {
                    f++;
                    
                    label6.Text = "3€";
                }
                else if (f == 3)
                {
                    f++;

                    label6.Text = "4€";
                }
                else if (f == 3)
                {
                    f++;

                    label6.Text = "5€";
                }
                else if (f == 4)
                {
                    f++;

                    label6.Text = "10€";
                }
                else if (f == 5)
                {
                    f++;

                    label6.Text = "15€";
                }
                else if (f == 6)
                {
                    f++;

                    label6.Text = "20€";
                }
                else if (f == 7)
                {
                    f++;

                    label6.Text = "25€";
                }
                else if (f == 8)
                {
                    f++;

                    label6.Text = "35€";
                }
                else if (f == 9)
                {
                    f++;

                    label6.Text = "40€";
                }
                else if (f == 10)
                {
                    f++;

                    label6.Text = "50€";
                }
                else if (f == 9)
                {
                    f++;

                    label6.Text = "All-in";
                }

            }
            
            if (i == 0)
            {
                i++ ;
                MessageBox.Show("Boas"+i.ToString());
            }
            else if (i == 1)
            {
                i++;
                MessageBox.Show("Adeus" + i.ToString());
            }
            
            while ( i <= 40)
            {
                i+=1;
                MessageBox.Show(i.ToString());
            }*/
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarmenu(panel8);
            menuescondido();
        }

        private void MenusDesign()
        {
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void menuescondido()
        {
            if (panel7.Visible == true)
                panel7.Visible = false;
            if (panel8.Visible == true)
                panel8.Visible = false;

        }

        private void mostrarmenu(Panel subMenu2)
        {
            if (subMenu2.Visible == false)
            {
                hideSubMenu();
                subMenu2.Visible = true;
            }
            else
            {
                subMenu2.Visible = false;
            }

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarmenu(panel7);
            menuescondido();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
            dinheiro += int.Parse(textBox1.Text); 
            
            label17.Text = dinheiro + "€";
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}

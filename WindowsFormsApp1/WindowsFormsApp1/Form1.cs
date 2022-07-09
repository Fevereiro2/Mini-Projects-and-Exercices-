using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool mouseDown;
        private Point offset;
        
        MySqlConnection sqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=system_fevereiro");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        string sql;
        int Resultado;
        Stopwatch cronometro = new Stopwatch();
        Thread nt;



        private void login()
        {
            
            string query = "SELECT * FROM register WHERE username='" + tb_loginlogin.Text + "' AND password= '" + tb_loginpass.Text + "'";
      
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;

            try
            {
                sqlConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())

                    {
                        MessageBox.Show("Login feito com sucesso");


                        lb_nome.Visible = true;
                        L_nomedb.Visible = true;
                        labeldasdasd.Visible = true;


                        L_nomedb.Text = "Olá " + tb_loginlogin.Text;
                        cronometro.Start();

                        btnJogos.Visible = true;
                        bntDepositar.Visible = true;
                        button5.Visible = true;



                    }
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro");
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");
            loginonoff();
            label3.Text = Date;
            tb_password.PasswordChar = '*';
            tb_password2.PasswordChar = '*';
            tb_loginpass.PasswordChar = '*';
            visibleregister();
            customDesign();
            visiblerlogin();



        }
        private void loginonoff()
        {
            btnJogos.Visible = false;
            bntDepositar.Visible = false;
            button5.Visible = false;
        }

        private void customDesign()
        {
            panelJogosSubmenu.Visible = false;
            panelcontaSubmenu.Visible = false;
            panelFaqsSubmenu.Visible = false;
            panelDepositarSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelJogosSubmenu.Visible == true)
                panelJogosSubmenu.Visible = false;
            if (panelcontaSubmenu.Visible == true)
                panelcontaSubmenu.Visible = false;
            if (panelFaqsSubmenu.Visible == true)
                panelFaqsSubmenu.Visible = false;
            if (panelDepositarSubmenu.Visible == true)
                panelDepositarSubmenu.Visible = false;
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


        /*
        private void conexaodb()
        {

            try
            { 
                sqlConnection.Open();
                label3.Text = "Connexaõ sucesso";
            } catch (Exception e)
            {
                label3.Text = "Connexaõ rejeitada";
            }
        }*/




        private void b_jogos_Click(object sender, EventArgs e)
        {
            





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_sair_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_max_Click(object sender, EventArgs e)
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



        private void b_slots_Click(object sender, EventArgs e)
        {
            
        }

        private void b_blackjack_Click(object sender, EventArgs e)
        {
           
        }

        private void b_roleta_Click(object sender, EventArgs e)
        {
            
        }

        private void b_news_Click(object sender, EventArgs e)
        {

        }

        private void b_registrar_Click(object sender, EventArgs e)
        {
            
        }

        private void b_entrarregistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void b_entrar_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ultimonome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_primeironome_TextChanged(object sender, EventArgs e)
        {

        }

        private  void errorinsert()
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            bool n = isvalid_name(tb_username.Text);
            bool p = isvalid_password(tb_password.Text);

            bool em = isvalid_email(tb_email.Text);
            bool p2 = isvalid_password2(tb_password2.Text);

            l_error9username.Visible = false;
            l_error1nome.Visible = false;
            l_error2email.Visible = false;
            l_error3password.Visible = false;
            l_error4idade.Visible = false;
            l_error5localidade.Visible = false;
            l_error6password2.Visible = false;
            l_error7telefone.Visible = false;
            l_error8sobrenome.Visible = false;

            if (tb_username.Text == "")
            {
                l_error9username.Visible = true;
                l_error9username.Text = "Campo incompleto";
            }
            if (tb_primeironome.Text == "")
            {
                l_error1nome.Visible = true;
                l_error1nome.Text = "Campo incompleto";
            }
            if (tb_ultimonome.Text == "")
            {
                l_error8sobrenome.Visible = true;
                l_error8sobrenome.Text = "Campo incompleto";
            }
            if (tb_email.Text == "")
            {
                l_error2email.Visible=true;
                l_error2email.Text = "Campo incompleto";
            }
            if (tb_password.Text == "")
            {
                l_error3password.Visible = true;
                l_error3password.Text = "Campo incompleto";
            }
            if (tb_password2.Text == "")
            {
                l_error6password2.Visible = true;
                l_error6password2.Text = "Campo incompleto";
            }
            if (tb_idade.Text == "")
            {
                l_error4idade.Visible = true;
                l_error4idade.Text = "Campo incompleto";
            }
            if (tb_telefone.Text == "")
            {
                l_error7telefone.Visible = true;
                l_error7telefone.Text = "Campo incompleto";
            }
            if (tb_rua.Text == "")
            {
                l_error5localidade.Visible = true;
                l_error5localidade.Text = "Campo incompleto";

            }



            /*

            if (tb_email.Text == "" && 
                tb_idade.Text == "" && 
                tb_password.Text == "" && 
                tb_password2.Text == "" && 
                tb_primeironome.Text =="" &&
                tb_ultimonome.Text == "" && 
                tb_rua.Text == ""&&
                tb_telefone.Text == ""&&
                tb_email.Text =="")
            {
                l_error1nome.Text = "Nome invalido";
                l_error1nome.Visible = true;

                l_error2email.Visible = true;
                

            }*/


            else if (tb_password.Text != tb_password2.Text)
            {
                MessageBox.Show("Insere a mesma password ");

            }
            else if (tb_password2.Text == tb_password2.Text)
            {

                sql = "Insert into `register`(`username` , `nome`, `sobrenome`, `email`, `telefone`, `password`, `password2`, `idade`, `Localidade`) values " +
                    "('" + tb_username.Text + "' " +
                    ",'" + tb_primeironome.Text + "' " +
                    ", '" + tb_ultimonome.Text + "'" +
                    ", '" + tb_email.Text + "'" +
                    ", '" + tb_telefone.Text + "'" +
                    ", '" + tb_password.Text + "'" +
                    ", '" + tb_password2.Text + "'" +
                    ", '" + tb_idade.Text + "'" +
                    ", '" + tb_rua.Text + "')";
                MyMethod(sql, "Impossivle resgitar na base de dados !", "Credenciais salvas");

                tb_rua.Clear();
                tb_password2.Clear();
                tb_password.Clear();
                tb_email.Clear();
                tb_idade.Clear();
                tb_rua.Clear();
                tb_primeironome.Clear();
                tb_ultimonome.Clear();
                tb_telefone.Clear();
                tb_username.Clear();

            }



        }

        public bool isvalid_password(string p)

        {
            Regex check = new Regex("^(.{0,7}|[^0-9]*|[^A-Z]*|[^a-z]*|[a-zA-Z0-9]*)$");
            bool valid = false ;
            valid = check.IsMatch(p);
            if (valid == true)
                return true ;
            else
            {
                MessageBox.Show("Password incorreta");
                return false ;
            }
        }
        public bool isvalid_password2(string p2)

        {
            Regex check = new Regex("^(.{0,7}|[^0-9]*|[^A-Z]*|[^a-z]*|[a-zA-Z0-9]*)$");
            
            bool valid = false;
            valid = check.IsMatch(p2);
            if (valid == true)
                return true;
            else
            {
                MessageBox.Show("Password incorreta");
                return false;
            }
        }

        public bool isvalid_name(string n)
        {
            Regex check = new Regex(@"^([A-Z][a-z-A-z]+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Nome incorreto, tens de colocar a primeira letra maiuscula");
                return valid;
            }
        }

        public bool isvalid_email(string email)
        {
            Regex check = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            bool valid = false;
            valid = check.IsMatch(email);
            if (valid == true)
                return true;
            else
            {
                MessageBox.Show("Email incorreto");
                return false;
            }
        }

        private void MyMethod(string sql, string msg_false, string msg_true)
        {
            try
            {
                sqlConnection.Open();
                cmd = new MySqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandText = sql;
                
                Resultado = cmd.ExecuteNonQuery();

                if (Resultado > 0)
                {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void Mybuscar(string query, string msg_falsa, string msg_verdadeira)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Register_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelJogosSubmenu);
            hideSubMenuRegister();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            hideSubMenuLogin();

            this.Close();
            nt = new Thread(slot);
            nt.SetApartmentState(ApartmentState.STA); //unica thread
            nt.Start();
        }

        private void slot()
        {
            Application.Run(new Form2());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            hideSubMenuLogin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            hideSubMenuLogin();

        }

        private void bntConta_Click(object sender, EventArgs e)
        {
            showSubMenu(panelcontaSubmenu);
            hideSubMenuRegister();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenuL(painel_login);
            
        }
        /**************************************/
        /**************************************/
        private void visiblerlogin()
        {
            painel_login.Visible = false;
            panel1.Visible = false;
        }

        private void hideSubMenuLogin()
        {
            if (painel_login.Visible == true)
                painel_login.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible=false;
        }

        private void showSubMenuL(Panel subMenuLogin)
        {
            if (subMenuLogin.Visible == false)
            {
                hideSubMenu();
                subMenuLogin.Visible = true;
            }
            else
            {
                subMenuLogin.Visible = false;
            }

        }
        /**************************************/
        /**************************************/

        private void button6_Click(object sender, EventArgs e)
        {
            

            hideSubMenu();
            hideSubMenuLogin();
            showSubMenuR(Register_panel);
        }

        private void visibleregister()
        {
            Register_panel.Visible = false;
        }

        private void hideSubMenuRegister()
        {
            if (Register_panel.Visible == true)
                Register_panel.Visible = false;
        }

        private void showSubMenuR(Panel subMenuRegister)
        {
            if (subMenuRegister.Visible == false)
            {
                hideSubMenu();
                subMenuRegister.Visible = true;
            }
            else
            {
                subMenuRegister.Visible = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            hideSubMenuLogin();
        }

        private void bntDepositar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDepositarSubmenu);
            hideSubMenuRegister();
            
        }

        private void bnt_Faq_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFaqsSubmenu);
            hideSubMenuRegister();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenuLogin();
        }

        private void label14_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

            login();
            /*
            String username, user_password;

            username = tb_loginlogin.Text;
            user_password = tb_loginpass.Text;
            
            sqlConnection.Open();

            try
            {
                sqlConnection.Open();
                string sql = "SELECT * FROM register WHERE username='" + tb_loginlogin + "' AND password= '" + tb_loginpass + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(sql, sqlConnection);

                DataTable register = new DataTable();
                sda.Fill(register);

                if (register.Rows.Count > 0)
                {
                    username = tb_loginlogin.Text;
                    user_password = tb_loginpass.Text;
                    MessageBox.Show("Login Sucesso");


                }
                else
                {
                    MessageBox.Show("Login Invalido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_loginlogin.Clear();
                    tb_loginpass.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Erro");
            }*/


            l_errorlogin1.Visible = false;
            l_errorlogin1.Visible = false ;

            if (tb_loginlogin.Text == "")
            {
                l_errorlogin1.Visible = true;
                l_errorlogin1.Text = "Campo incompleto";
            }
            if (tb_loginpass.Text == "")
            {
                l_errorlogin2.Visible = true;
                l_errorlogin2.Text = "Campo incompleto";
            }




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

        private void tb_loginlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenuLogin();
            hideSubMenu();

            showSubMenuR(panel1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenuLogin();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hideSubMenuLogin();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hideSubMenuLogin();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideSubMenuLogin();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://forms.gle/E9wNZmWnmZBL5MST9");
        }

        private void lb_nome_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lb_nome.Text = string.Format("{0:hh\\:mm\\:ss}", cronometro.Elapsed);
        }

        private void L_nomedb_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void painel_login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

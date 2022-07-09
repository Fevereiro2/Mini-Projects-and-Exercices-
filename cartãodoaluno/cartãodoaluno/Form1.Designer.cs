namespace cartãodoaluno
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.l_nome = new System.Windows.Forms.Label();
            this.l_morada = new System.Windows.Forms.Label();
            this.l_telefone = new System.Windows.Forms.Label();
            this.l_nascimento = new System.Windows.Forms.Label();
            this.l_sexo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_morada = new System.Windows.Forms.TextBox();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.tb_nascimento = new System.Windows.Forms.TextBox();
            this.l_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.b_editar1 = new System.Windows.Forms.Button();
            this.b_editar2 = new System.Windows.Forms.Button();
            this.b_editar3 = new System.Windows.Forms.Button();
            this.b_editar4 = new System.Windows.Forms.Button();
            this.b_editar5 = new System.Windows.Forms.Button();
            this.b_validar = new System.Windows.Forms.Button();
            this.b_sair = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.l_resultados = new System.Windows.Forms.Label();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.feminino = new System.Windows.Forms.RadioButton();
            this.b_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // l_nome
            // 
            this.l_nome.AutoSize = true;
            this.l_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nome.Location = new System.Drawing.Point(38, 256);
            this.l_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_nome.Name = "l_nome";
            this.l_nome.Size = new System.Drawing.Size(59, 20);
            this.l_nome.TabIndex = 0;
            this.l_nome.Text = "Nome :";
            this.l_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_morada
            // 
            this.l_morada.AutoSize = true;
            this.l_morada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_morada.Location = new System.Drawing.Point(38, 285);
            this.l_morada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_morada.Name = "l_morada";
            this.l_morada.Size = new System.Drawing.Size(71, 20);
            this.l_morada.TabIndex = 1;
            this.l_morada.Text = "Morada :";
            // 
            // l_telefone
            // 
            this.l_telefone.AutoSize = true;
            this.l_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_telefone.Location = new System.Drawing.Point(38, 317);
            this.l_telefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_telefone.Name = "l_telefone";
            this.l_telefone.Size = new System.Drawing.Size(79, 20);
            this.l_telefone.TabIndex = 2;
            this.l_telefone.Text = "Telefone :";
            this.l_telefone.Click += new System.EventHandler(this.l_telefone_Click);
            // 
            // l_nascimento
            // 
            this.l_nascimento.AutoSize = true;
            this.l_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nascimento.Location = new System.Drawing.Point(38, 377);
            this.l_nascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_nascimento.Name = "l_nascimento";
            this.l_nascimento.Size = new System.Drawing.Size(134, 20);
            this.l_nascimento.TabIndex = 3;
            this.l_nascimento.Text = "Ano Nascimento :";
            this.l_nascimento.Click += new System.EventHandler(this.l_nascimento_Click);
            // 
            // l_sexo
            // 
            this.l_sexo.AutoSize = true;
            this.l_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_sexo.Location = new System.Drawing.Point(38, 405);
            this.l_sexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_sexo.Name = "l_sexo";
            this.l_sexo.Size = new System.Drawing.Size(53, 20);
            this.l_sexo.TabIndex = 4;
            this.l_sexo.Text = "Sexo :";
            this.l_sexo.Click += new System.EventHandler(this.l_sexo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 233);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(245, 48);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(556, 154);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(176, 256);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.ReadOnly = true;
            this.tb_nome.ShortcutsEnabled = false;
            this.tb_nome.Size = new System.Drawing.Size(174, 20);
            this.tb_nome.TabIndex = 9;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // tb_morada
            // 
            this.tb_morada.Enabled = false;
            this.tb_morada.Location = new System.Drawing.Point(176, 285);
            this.tb_morada.Margin = new System.Windows.Forms.Padding(2);
            this.tb_morada.Name = "tb_morada";
            this.tb_morada.ReadOnly = true;
            this.tb_morada.Size = new System.Drawing.Size(174, 20);
            this.tb_morada.TabIndex = 10;
            this.tb_morada.TextChanged += new System.EventHandler(this.tb_morada_TextChanged);
            // 
            // tb_telefone
            // 
            this.tb_telefone.Enabled = false;
            this.tb_telefone.Location = new System.Drawing.Point(176, 317);
            this.tb_telefone.Margin = new System.Windows.Forms.Padding(2);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.ReadOnly = true;
            this.tb_telefone.Size = new System.Drawing.Size(174, 20);
            this.tb_telefone.TabIndex = 11;
            this.tb_telefone.TextChanged += new System.EventHandler(this.tb_telefone_TextChanged);
            // 
            // tb_nascimento
            // 
            this.tb_nascimento.Enabled = false;
            this.tb_nascimento.Location = new System.Drawing.Point(176, 377);
            this.tb_nascimento.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nascimento.Name = "tb_nascimento";
            this.tb_nascimento.ReadOnly = true;
            this.tb_nascimento.Size = new System.Drawing.Size(174, 20);
            this.tb_nascimento.TabIndex = 12;
            this.tb_nascimento.TextChanged += new System.EventHandler(this.tb_nascimento_TextChanged);
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_email.Location = new System.Drawing.Point(38, 348);
            this.l_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(56, 20);
            this.l_email.TabIndex = 13;
            this.l_email.Text = "Email :";
            // 
            // tb_email
            // 
            this.tb_email.Enabled = false;
            this.tb_email.Location = new System.Drawing.Point(176, 348);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(174, 20);
            this.tb_email.TabIndex = 14;
            // 
            // b_editar1
            // 
            this.b_editar1.Location = new System.Drawing.Point(367, 256);
            this.b_editar1.Name = "b_editar1";
            this.b_editar1.Size = new System.Drawing.Size(75, 20);
            this.b_editar1.TabIndex = 15;
            this.b_editar1.Text = "editar";
            this.b_editar1.UseVisualStyleBackColor = true;
            this.b_editar1.Click += new System.EventHandler(this.b_editar1_Click);
            // 
            // b_editar2
            // 
            this.b_editar2.Location = new System.Drawing.Point(367, 285);
            this.b_editar2.Name = "b_editar2";
            this.b_editar2.Size = new System.Drawing.Size(75, 20);
            this.b_editar2.TabIndex = 16;
            this.b_editar2.Text = "editar";
            this.b_editar2.UseVisualStyleBackColor = true;
            this.b_editar2.Click += new System.EventHandler(this.b_editar2_Click);
            // 
            // b_editar3
            // 
            this.b_editar3.Location = new System.Drawing.Point(367, 317);
            this.b_editar3.Name = "b_editar3";
            this.b_editar3.Size = new System.Drawing.Size(75, 20);
            this.b_editar3.TabIndex = 17;
            this.b_editar3.Text = "editar";
            this.b_editar3.UseVisualStyleBackColor = true;
            this.b_editar3.Click += new System.EventHandler(this.b_editar3_Click);
            // 
            // b_editar4
            // 
            this.b_editar4.Location = new System.Drawing.Point(367, 347);
            this.b_editar4.Name = "b_editar4";
            this.b_editar4.Size = new System.Drawing.Size(75, 20);
            this.b_editar4.TabIndex = 18;
            this.b_editar4.Text = "editar";
            this.b_editar4.UseVisualStyleBackColor = true;
            this.b_editar4.Click += new System.EventHandler(this.b_editar4_Click);
            // 
            // b_editar5
            // 
            this.b_editar5.Location = new System.Drawing.Point(367, 377);
            this.b_editar5.Name = "b_editar5";
            this.b_editar5.Size = new System.Drawing.Size(75, 20);
            this.b_editar5.TabIndex = 19;
            this.b_editar5.Text = "editar";
            this.b_editar5.UseVisualStyleBackColor = true;
            this.b_editar5.Click += new System.EventHandler(this.b_editar5_Click);
            // 
            // b_validar
            // 
            this.b_validar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.b_validar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_validar.Location = new System.Drawing.Point(508, 426);
            this.b_validar.Name = "b_validar";
            this.b_validar.Size = new System.Drawing.Size(75, 23);
            this.b_validar.TabIndex = 20;
            this.b_validar.Text = "Validar";
            this.b_validar.UseVisualStyleBackColor = false;
            this.b_validar.Click += new System.EventHandler(this.b_validar_Click);
            // 
            // b_sair
            // 
            this.b_sair.BackColor = System.Drawing.Color.Red;
            this.b_sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_sair.Location = new System.Drawing.Point(612, 426);
            this.b_sair.Name = "b_sair";
            this.b_sair.Size = new System.Drawing.Size(75, 23);
            this.b_sair.TabIndex = 21;
            this.b_sair.Text = "Sair";
            this.b_sair.UseVisualStyleBackColor = false;
            this.b_sair.Click += new System.EventHandler(this.b_sair_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // l_resultados
            // 
            this.l_resultados.Location = new System.Drawing.Point(505, 252);
            this.l_resultados.Name = "l_resultados";
            this.l_resultados.Size = new System.Drawing.Size(267, 145);
            this.l_resultados.TabIndex = 25;
            this.l_resultados.Click += new System.EventHandler(this.label3_Click);
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(133, 408);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(73, 17);
            this.masculino.TabIndex = 26;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            this.masculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // feminino
            // 
            this.feminino.AutoSize = true;
            this.feminino.Location = new System.Drawing.Point(232, 408);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(67, 17);
            this.feminino.TabIndex = 27;
            this.feminino.TabStop = true;
            this.feminino.Text = "Feminino";
            this.feminino.UseVisualStyleBackColor = true;
            this.feminino.CheckedChanged += new System.EventHandler(this.rd_feminino_CheckedChanged);
            // 
            // b_limpar
            // 
            this.b_limpar.BackColor = System.Drawing.Color.SteelBlue;
            this.b_limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_limpar.Location = new System.Drawing.Point(411, 426);
            this.b_limpar.Name = "b_limpar";
            this.b_limpar.Size = new System.Drawing.Size(75, 23);
            this.b_limpar.TabIndex = 28;
            this.b_limpar.Text = "Limpar";
            this.b_limpar.UseVisualStyleBackColor = false;
            this.b_limpar.Click += new System.EventHandler(this.b_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.b_limpar);
            this.Controls.Add(this.feminino);
            this.Controls.Add(this.masculino);
            this.Controls.Add(this.l_resultados);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.b_sair);
            this.Controls.Add(this.b_validar);
            this.Controls.Add(this.b_editar5);
            this.Controls.Add(this.b_editar4);
            this.Controls.Add(this.b_editar3);
            this.Controls.Add(this.b_editar2);
            this.Controls.Add(this.b_editar1);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.tb_nascimento);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.tb_morada);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.l_sexo);
            this.Controls.Add(this.l_nascimento);
            this.Controls.Add(this.l_telefone);
            this.Controls.Add(this.l_morada);
            this.Controls.Add(this.l_nome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_nome;
        private System.Windows.Forms.Label l_morada;
        private System.Windows.Forms.Label l_telefone;
        private System.Windows.Forms.Label l_nascimento;
        private System.Windows.Forms.Label l_sexo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_morada;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.TextBox tb_nascimento;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button b_editar1;
        private System.Windows.Forms.Button b_editar2;
        private System.Windows.Forms.Button b_editar3;
        private System.Windows.Forms.Button b_editar4;
        private System.Windows.Forms.Button b_editar5;
        private System.Windows.Forms.Button b_validar;
        private System.Windows.Forms.Button b_sair;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label l_resultados;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.RadioButton feminino;
        private System.Windows.Forms.Button b_limpar;
    }
}


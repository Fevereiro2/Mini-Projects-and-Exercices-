namespace PrimeiroWindowsForms
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
            this.bsair = new System.Windows.Forms.Button();
            this.bconfirmar = new System.Windows.Forms.Button();
            this.LNOME = new System.Windows.Forms.Label();
            this.TBOX1 = new System.Windows.Forms.TextBox();
            this.lvazio = new System.Windows.Forms.Label();
            this.bvermelho = new System.Windows.Forms.Button();
            this.bverde = new System.Windows.Forms.Button();
            this.bazul = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsair
            // 
            this.bsair.BackColor = System.Drawing.Color.IndianRed;
            this.bsair.Font = new System.Drawing.Font("Microsoft Himalaya", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsair.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bsair.Location = new System.Drawing.Point(652, 359);
            this.bsair.Name = "bsair";
            this.bsair.Size = new System.Drawing.Size(120, 64);
            this.bsair.TabIndex = 0;
            this.bsair.Text = "Sair";
            this.bsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bsair.UseVisualStyleBackColor = false;
            this.bsair.Click += new System.EventHandler(this.bsair_Click);
            // 
            // bconfirmar
            // 
            this.bconfirmar.BackColor = System.Drawing.Color.IndianRed;
            this.bconfirmar.Font = new System.Drawing.Font("Microsoft Himalaya", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bconfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bconfirmar.Location = new System.Drawing.Point(41, 359);
            this.bconfirmar.Name = "bconfirmar";
            this.bconfirmar.Size = new System.Drawing.Size(209, 64);
            this.bconfirmar.TabIndex = 1;
            this.bconfirmar.Text = "confirmar";
            this.bconfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bconfirmar.UseVisualStyleBackColor = false;
            this.bconfirmar.Click += new System.EventHandler(this.bconfirmar_Click);
            // 
            // LNOME
            // 
            this.LNOME.BackColor = System.Drawing.Color.Transparent;
            this.LNOME.Location = new System.Drawing.Point(12, 22);
            this.LNOME.Name = "LNOME";
            this.LNOME.Size = new System.Drawing.Size(354, 76);
            this.LNOME.TabIndex = 2;
            this.LNOME.Text = "NOME:";
            this.LNOME.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBOX1
            // 
            this.TBOX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBOX1.Location = new System.Drawing.Point(12, 50);
            this.TBOX1.Multiline = true;
            this.TBOX1.Name = "TBOX1";
            this.TBOX1.Size = new System.Drawing.Size(376, 43);
            this.TBOX1.TabIndex = 3;
            this.TBOX1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lvazio
            // 
            this.lvazio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvazio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvazio.CausesValidation = false;
            this.lvazio.Location = new System.Drawing.Point(12, 102);
            this.lvazio.Name = "lvazio";
            this.lvazio.Size = new System.Drawing.Size(376, 107);
            this.lvazio.TabIndex = 4;
            this.lvazio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lvazio.Click += new System.EventHandler(this.l_Click);
            // 
            // bvermelho
            // 
            this.bvermelho.BackColor = System.Drawing.Color.Red;
            this.bvermelho.Font = new System.Drawing.Font("Microsoft Himalaya", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvermelho.ForeColor = System.Drawing.Color.DarkGray;
            this.bvermelho.Location = new System.Drawing.Point(652, 53);
            this.bvermelho.Name = "bvermelho";
            this.bvermelho.Size = new System.Drawing.Size(136, 63);
            this.bvermelho.TabIndex = 5;
            this.bvermelho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bvermelho.UseVisualStyleBackColor = false;
            this.bvermelho.Click += new System.EventHandler(this.bvermelho_Click);
            // 
            // bverde
            // 
            this.bverde.BackColor = System.Drawing.Color.Lime;
            this.bverde.Font = new System.Drawing.Font("Microsoft Himalaya", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bverde.ForeColor = System.Drawing.Color.DarkGray;
            this.bverde.Location = new System.Drawing.Point(652, 146);
            this.bverde.Name = "bverde";
            this.bverde.Size = new System.Drawing.Size(136, 63);
            this.bverde.TabIndex = 6;
            this.bverde.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bverde.UseVisualStyleBackColor = false;
            this.bverde.Click += new System.EventHandler(this.bverde_Click);
            // 
            // bazul
            // 
            this.bazul.BackColor = System.Drawing.Color.Blue;
            this.bazul.Font = new System.Drawing.Font("Microsoft Himalaya", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bazul.ForeColor = System.Drawing.Color.DarkGray;
            this.bazul.Location = new System.Drawing.Point(652, 244);
            this.bazul.Name = "bazul";
            this.bazul.Size = new System.Drawing.Size(136, 63);
            this.bazul.TabIndex = 7;
            this.bazul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bazul.UseVisualStyleBackColor = false;
            this.bazul.Click += new System.EventHandler(this.bazul_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bazul);
            this.Controls.Add(this.bverde);
            this.Controls.Add(this.bvermelho);
            this.Controls.Add(this.lvazio);
            this.Controls.Add(this.TBOX1);
            this.Controls.Add(this.LNOME);
            this.Controls.Add(this.bconfirmar);
            this.Controls.Add(this.bsair);
            this.Name = "Form1";
            this.Text = "Fevereiro APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsair;
        private System.Windows.Forms.Button bconfirmar;
        private System.Windows.Forms.Label LNOME;
        private System.Windows.Forms.TextBox TBOX1;
        private System.Windows.Forms.Label lvazio;
        private System.Windows.Forms.Button bvermelho;
        private System.Windows.Forms.Button bverde;
        private System.Windows.Forms.Button bazul;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


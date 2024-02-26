namespace ProjetoIEFPMusic
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAddBanda = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnAddMusica = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnListarBanda = new System.Windows.Forms.TextBox();
            this.btnListarMusicas = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox3.Location = new System.Drawing.Point(24, 244);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 21);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "SUA BIBLIOTECA";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnAddBanda
            // 
            this.btnAddBanda.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnAddBanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnAddBanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddBanda.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddBanda.Location = new System.Drawing.Point(64, 126);
            this.btnAddBanda.Name = "btnAddBanda";
            this.btnAddBanda.Size = new System.Drawing.Size(259, 23);
            this.btnAddBanda.TabIndex = 6;
            this.btnAddBanda.Text = "Adicionar Artista";
            this.btnAddBanda.Click += new System.EventHandler(this.btnAddBanda_Click);
            this.btnAddBanda.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 176);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnAddMusica
            // 
            this.btnAddMusica.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnAddMusica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnAddMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddMusica.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddMusica.Location = new System.Drawing.Point(64, 177);
            this.btnAddMusica.Name = "btnAddMusica";
            this.btnAddMusica.Size = new System.Drawing.Size(166, 23);
            this.btnAddMusica.TabIndex = 8;
            this.btnAddMusica.Text = "Adicionar Musica";
            this.btnAddMusica.Click += new System.EventHandler(this.btnAddMusica_Click);
            this.btnAddMusica.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(256, 276);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(625, 175);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.UseWaitCursor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(417, 68);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(302, 165);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnListarBanda
            // 
            this.btnListarBanda.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnListarBanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnListarBanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnListarBanda.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListarBanda.Location = new System.Drawing.Point(63, 314);
            this.btnListarBanda.Name = "btnListarBanda";
            this.btnListarBanda.Size = new System.Drawing.Size(139, 23);
            this.btnListarBanda.TabIndex = 12;
            this.btnListarBanda.Text = "Listar Artistas";
            this.btnListarBanda.Click += new System.EventHandler(this.btnListarBanda_Click);
            this.btnListarBanda.TextChanged += new System.EventHandler(this.btnListarBanda_TextChanged);
            // 
            // btnListarMusicas
            // 
            this.btnListarMusicas.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnListarMusicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnListarMusicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnListarMusicas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListarMusicas.Location = new System.Drawing.Point(63, 378);
            this.btnListarMusicas.Name = "btnListarMusicas";
            this.btnListarMusicas.Size = new System.Drawing.Size(139, 23);
            this.btnListarMusicas.TabIndex = 14;
            this.btnListarMusicas.Text = "Listar Musicas";
            this.btnListarMusicas.Click += new System.EventHandler(this.btnListarMusicas_Click);
            this.btnListarMusicas.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(18, 376);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(952, 529);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnListarMusicas);
            this.Controls.Add(this.btnListarBanda);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnAddMusica);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnAddBanda);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox btnAddBanda;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox btnAddMusica;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox btnListarBanda;
        private System.Windows.Forms.TextBox btnListarMusicas;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}


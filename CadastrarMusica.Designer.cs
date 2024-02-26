namespace ProjetoIEFPMusic
{
    partial class CadastrarMusica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarMusica));
            this.adicionarMusica = new System.Windows.Forms.Button();
            this.nomeBanda = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.nomeMusica = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // adicionarMusica
            // 
            this.adicionarMusica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adicionarMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.adicionarMusica.Location = new System.Drawing.Point(476, 278);
            this.adicionarMusica.Name = "adicionarMusica";
            this.adicionarMusica.Size = new System.Drawing.Size(103, 29);
            this.adicionarMusica.TabIndex = 19;
            this.adicionarMusica.Text = "Adicionar";
            this.adicionarMusica.UseVisualStyleBackColor = false;
            this.adicionarMusica.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomeBanda
            // 
            this.nomeBanda.Location = new System.Drawing.Point(417, 139);
            this.nomeBanda.Name = "nomeBanda";
            this.nomeBanda.Size = new System.Drawing.Size(226, 22);
            this.nomeBanda.TabIndex = 18;
            this.nomeBanda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(434, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 19);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "Digite o nome do artista:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(32, 118);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(256, 139);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // nomeMusica
            // 
            this.nomeMusica.Location = new System.Drawing.Point(417, 235);
            this.nomeMusica.Name = "nomeMusica";
            this.nomeMusica.Size = new System.Drawing.Size(226, 22);
            this.nomeMusica.TabIndex = 21;
            this.nomeMusica.TextChanged += new System.EventHandler(this.nomeMusica_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(434, 201);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 19);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Digite o nome da musica:";
            // 
            // CadastrarMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nomeMusica);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.adicionarMusica);
            this.Controls.Add(this.nomeBanda);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.pictureBox5);
            this.Name = "CadastrarMusica";
            this.Text = "Musica";
            this.Load += new System.EventHandler(this.CadastrarMusica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionarMusica;
        private System.Windows.Forms.TextBox nomeBanda;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox nomeMusica;
        private System.Windows.Forms.TextBox textBox3;
    }
}
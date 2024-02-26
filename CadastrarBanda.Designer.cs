namespace ProjetoIEFPMusic
{
    partial class CadastrarBanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarBanda));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.nomeBanda = new System.Windows.Forms.TextBox();
            this.adicionarBanda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(28, 116);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(256, 139);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(438, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(230, 19);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Digite o nome do artista:";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // nomeBanda
            // 
            this.nomeBanda.Location = new System.Drawing.Point(405, 158);
            this.nomeBanda.Name = "nomeBanda";
            this.nomeBanda.Size = new System.Drawing.Size(250, 22);
            this.nomeBanda.TabIndex = 14;
            this.nomeBanda.TextChanged += new System.EventHandler(this.nomeBanda_TextChanged);
            // 
            // adicionarBanda
            // 
            this.adicionarBanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adicionarBanda.FlatAppearance.BorderSize = 0;
            this.adicionarBanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarBanda.Location = new System.Drawing.Point(478, 205);
            this.adicionarBanda.Name = "adicionarBanda";
            this.adicionarBanda.Size = new System.Drawing.Size(103, 29);
            this.adicionarBanda.TabIndex = 15;
            this.adicionarBanda.Text = "Adicionar";
            this.adicionarBanda.UseVisualStyleBackColor = false;
            this.adicionarBanda.Click += new System.EventHandler(this.adicionarBanda_click);
            // 
            // CadastrarBanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adicionarBanda);
            this.Controls.Add(this.nomeBanda);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.pictureBox5);
            this.Name = "CadastrarBanda";
            this.Text = "CadastrarBanda";
            this.Load += new System.EventHandler(this.CadastrarBanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox nomeBanda;
        private System.Windows.Forms.Button adicionarBanda;
    }
}
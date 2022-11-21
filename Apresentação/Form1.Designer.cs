using System;

namespace Projeto_Fadami_login1
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
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonCadastreSe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.Location = new System.Drawing.Point(281, 153);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(79, 31);
            this.buttonEntrar.TabIndex = 0;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(229, 58);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(49, 15);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "LOGIN";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(229, 101);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(53, 15);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "SENHA";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(290, 58);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(177, 20);
            this.textBoxLogin.TabIndex = 4;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(290, 101);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(177, 20);
            this.textBoxSenha.TabIndex = 5;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(389, 153);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(84, 31);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonCadastreSe
            // 
            this.buttonCadastreSe.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastreSe.Location = new System.Drawing.Point(326, 211);
            this.buttonCadastreSe.Name = "buttonCadastreSe";
            this.buttonCadastreSe.Size = new System.Drawing.Size(100, 38);
            this.buttonCadastreSe.TabIndex = 7;
            this.buttonCadastreSe.Text = "Cadastre-se";
            this.buttonCadastreSe.UseVisualStyleBackColor = false;
            this.buttonCadastreSe.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(526, 325);
            this.Controls.Add(this.buttonCadastreSe);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnCadastrese;
        private readonly EventHandler btnSair_Click;
        private readonly EventHandler btnCadastrese_Click;
        private readonly EventHandler lblSenha_Load;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonCadastreSe;
    }
}


namespace Projeto_Fadami_login1.Apresentação
{
    partial class CadastreSe
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbConfSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(30, 34);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 15);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(30, 105);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 15);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(30, 183);
            this.lblConfirmarSenha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(100, 15);
            this.lblConfirmarSenha.TabIndex = 2;
            this.lblConfirmarSenha.Text = "Confirmar senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(118, 274);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 40);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(33, 62);
            this.txbLogin.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(226, 25);
            this.txbLogin.TabIndex = 4;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(33, 134);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(179, 25);
            this.txbSenha.TabIndex = 5;
            // 
            // txbConfSenha
            // 
            this.txbConfSenha.Location = new System.Drawing.Point(33, 212);
            this.txbConfSenha.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txbConfSenha.Name = "txbConfSenha";
            this.txbConfSenha.Size = new System.Drawing.Size(179, 25);
            this.txbConfSenha.TabIndex = 6;
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(339, 379);
            this.Controls.Add(this.txbConfSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "CadastreSe";
            this.Text = "Cadastre_se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbConfSenha;
    }
}
using Projeto_Fadami_login1.Apresentação;
using Projeto_Fadami_login1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Fadami_login1
{
    public partial class Form1 : Form
    {
        private object ERRO;

        public object Cadastrese { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, MessageBoxButtons messageBoxButtons)
        {
            Controle controle = new Controle();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)

                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo_Usuário bv = new BemVindo_Usuário();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Controle Controle = new Controle();
            Controle.acessar(textBoxLogin.Text, textBoxSenha.Text);
            if (Controle.mensagem.Equals(""))
            {
                if (Controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo_Usuário bv = new BemVindo_Usuário();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e Senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Controle.mensagem);
            }
        }
    }
}

    


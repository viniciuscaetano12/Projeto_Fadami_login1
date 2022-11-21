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

namespace Projeto_Fadami_login1.Apresentação
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txbLogin.Text,txbSenha.Text, txbConfSenha.Text);
            if(controle.tem) //mensagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem); //mensagem de erro
            }
        }

             // Senhas tem que conter caracteres e numeros(regras) (quantidade de numeros)
             // Antes de cadastrar verificar se já existe e-mail com este nome
             // ......................
    }
}

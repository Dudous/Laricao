using Controle;
using LaricãoHamburgueria;
using Modelo;
using System;
using System.Windows.Forms;

namespace Laricão
{
    public partial class FrmCadastar : Form
    {
        public FrmCadastar()
        {
            InitializeComponent();
        }
        UsuarioModelo modelo = new UsuarioModelo();
        UsuarioControle controle = new UsuarioControle();
        Conexao con = new Conexao();

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            if (TextBoxVazias())
                MessageBox.Show("Preencha Todos os Campos");

            else if (txtsenha.Text == txtsenha1.Text)
            {
                modelo.nome = txtnome.Text;
                modelo.sobrenome = txtsobre.Text;
                modelo.cpf = txtcpf.Text;
                modelo.email = txtemail.Text;
                modelo.tel = txttel.Text;
                modelo.senha = txtsenha.Text;
                modelo.idperfil = cbperfil.SelectedIndex + 1;

                if (!controle.ValidarCPF(modelo.cpf))
                    MessageBox.Show("CPF inválido");
                else
                {
                    if (con.ValidaCadastro(modelo.email, modelo.cpf))
                    {
                        MessageBox.Show("Usuário já possúi Cadastro");
                    }
                    else
                    {
                        controle.Cadastrar(modelo);
                        MessageBox.Show("Usuário Cadastrado");
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("As senhas devem ser iguais");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool TextBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            return false;
        }
    }
}

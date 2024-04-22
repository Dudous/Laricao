using Controle;
using Laricão;
using Modelo;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace LaricãoHamburgueria
{
    public partial class Login : Form
    {
        UsuarioControle controle = new UsuarioControle();
        UsuarioModelo modelo = new UsuarioModelo();
        Conexao con = new Conexao();
        PrivateFontCollection pfc = new PrivateFontCollection();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pfc.AddFontFile("E:\\Laricao\\img\\Gluten.ttf");
            Font padrao = new Font(pfc.Families[0], 16, FontStyle.Regular);
            gunaLabel1.Font = padrao;
            gunaLabel2.Font = padrao;
            gunaLabel3.Font = padrao;

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

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogar_Click(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            modelo.email = txtLogin.Text;
            modelo.senha = txtSenha.Text;
            if (TextBoxVazias())
                MessageBox.Show("Preencha os Campos Vazios");
            else if (controle.logar(modelo))
            {
                this.Hide();
                FrmMenu Menu = new FrmMenu();

                Menu.Show();
            }
            else
                MessageBox.Show("Usuário ou Senha inválidos");
        }

        private void Ajuda(object sender, EventArgs e)
        {
            try
            {
                string caminhopdf = "E:\\Laricao\\manual\\Manual-login.pdf";
                if (System.IO.File.Exists(caminhopdf))
                {
                    Process.Start(caminhopdf);
                }
                else
                {
                    MessageBox.Show("Arquivo de Ajuda não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
        private void btnRec_Click(object sender, EventArgs e)
        {
            MessageBox.Show(con.recuperaremail(txtLogin.Text));
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEscolha escolha = new FrmEscolha();
            escolha.Show();

        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Login")
                txtLogin.Text = null;
        }
        private void Senha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
                txtSenha.Text = null;
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
                txtLogin.Text = "Login";
        }
        private void Senha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
                txtSenha.Text = "Senha";
        }
    }

}

using Controle;
using LaricãoHamburgueria;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Laricão
{
    public partial class FrmMenu : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        int perfilusuario;

        public FrmMenu()
        {
            InitializeComponent();

            perfilusuario = UsuarioControle.perfil;
            if (perfilusuario != 2)
            {
                btnClientes.Visible = false;
                BtnProdutos.Visible = false;
            }

        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pfc.AddFontFile("E:\\Laricao\\img\\Gluten.ttf");
            Font padrao = new Font(pfc.Families[0], 16, FontStyle.Regular);
            label1.Font = padrao;
            label2.Font = padrao;
            label3.Font = padrao;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }


        private void btnCardapio_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCardapio());
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCarrinho());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AddControls(new FrmPedidos());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new FrmHome());
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            AddControls(new FrmClientes());
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            AddControls(new FrmProduto());
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            DialogResult excluir = MessageBox.Show("Tem certeza que deseja Sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (excluir == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }
        private void Ajuda(object sender, EventArgs e)
        {
            try
            {
                string caminhopdf = "E:\\Laricao\\manual\\Manual-sistema.pdf";
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
    }
}
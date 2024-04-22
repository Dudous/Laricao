using Controle;
using LaricãoHamburgueria;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Speech.Synthesis;

namespace Laricão
{
    public partial class FrmSenhaView : Form
    {
        private const string SenhaCorreta = "balde";
        PrivateFontCollection pfc = new PrivateFontCollection();
        public FrmSenhaView()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmSenhaView_Load);
        }

        private void FrmSenhaView_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("E:\\Laricao\\img\\Gluten.ttf");
            Font padrao = new Font(pfc.Families[0], 16, FontStyle.Regular);
            //gunaLabel1.Font = padrao;
        }

        private void btnok_Click(object sender, EventArgs e)
        {

            string senhaDigitada = gunaTextBox1.Text;

            if (senhaDigitada == SenhaCorreta)
            {

                // Exibir mensagem com o ID do usuário

                // Esconder o formulário atual

                // Abrir o formulário de cadastro
                Cadastro menu = new Cadastro();
                this.Hide();
                menu.Show();
            }
            else
            {
                // Senha incorreta, exibir mensagem de erro
                MessageBox.Show("Senha incorreta. Tente novamente.");
            }
        }


        private void btncancel_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            this.Hide();
            login.Show();

        }

        private void FrmSenhaView_Load_1(object sender, EventArgs e)
        {
            pfc.AddFontFile("E:\\Laricao\\img\\Gluten.ttf");
            Font padrao = new Font(pfc.Families[0], 10, FontStyle.Regular);

        }
    }
}

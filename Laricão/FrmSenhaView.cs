using Controle;
using LaricãoHamburgueria;
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
        private const string SenhaCorreta = "1234";
      //  private SpeechSynthesizer synthesizer;
        public FrmSenhaView()
        {

            InitializeComponent();
          //  synthesizer = new SpeechSynthesizer();
            gunaButton1.Click += gunaButton1_Click;
            this.Load += new EventHandler(FrmSenhaView_Load);

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSenhaView_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("E:\\Laricao\\img\\Gluten.ttf");
            Font padrao = new Font(pfc.Families[0], 16, FontStyle.Regular);
            gunaLabel1.Font = padrao;
            this.CenterToScreen();

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string senhaDigitada = txtsenha.Text;
            //synthesizer.SpeakAsync("digite a senha de administrador");

            if (senhaDigitada == SenhaCorreta)
            {
                // Definir o ID do usuário
                UsuarioControle.id = 2;

                // Exibir mensagem com o ID do usuário
                MessageBox.Show($"O ID do usuário é: {UsuarioControle.id}");

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

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

            // Abrir o formulário de cadastro
            Login login = new Login();
            this.Hide();
            login.Show();

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

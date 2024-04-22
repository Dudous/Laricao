using Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laricão
{
    public partial class FrmEscolher : Form
    {
        private const string SenhaCorreta = "1234";
        public FrmEscolher()
        {
            InitializeComponent();
            gunaImageButton1.Click += gunaImageButton1_Click;
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
         
            UsuarioControle.id = 1;

            MessageBox.Show($"O ID do usuário é: {UsuarioControle.id}");
            this.Hide();
            Cadastro Menu = new Cadastro();

            Menu.Show();

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
           View.FrmSenhaView View = new View.FrmSenhaView();
            this.Hide();
            View.Show();
        }

    }
}

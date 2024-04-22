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
    public partial class FrmEscolha : Form
    {
        public FrmEscolha()
        {
            InitializeComponent();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {

            UsuarioControle.perfil = 1;
            this.Hide();
            Cadastro Menu = new Cadastro();
            Menu.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            UsuarioControle.perfil = 2;
            FrmSenhaView View = new FrmSenhaView();
            this.Hide();
            View.Show();
        }

    }
}

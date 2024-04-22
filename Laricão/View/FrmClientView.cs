using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;
using Modelo;

namespace Laricão.View
{
    public partial class FrmClientView : Form
    {
        UsuarioModelo modelo = new UsuarioModelo();
        UsuarioControle controle = new UsuarioControle();

        public int id;

        public FrmClientView()
        {
            InitializeComponent();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            modelo.id = id;
            modelo.nome = txtnome.Text;
            modelo.sobrenome = txtsobre.Text;
            modelo.cpf = txtcpf.Text;
            modelo.tel = txttel.Text;
            modelo.idperfil = cbperfil.SelectedIndex + 1;
            modelo.email = txtemail.Text;
            if (txtsenha != null)
                if (txtsenha.Text == txtsenha1.Text)
                    modelo.senha = txtsenha.Text;
                else
                {
                    MessageBox.Show("As Senhas devem ser Iguais");
                    this.Close();
                }
            controle.Editar(modelo);
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientView_Load(object sender, EventArgs e)
        {

        }
    }
}

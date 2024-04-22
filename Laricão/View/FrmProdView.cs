using Controle;
using Modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laricão.View
{
    public partial class FrmProdView : Form
    {

        ModeloProduto modelo = new ModeloProduto();
        ControleProduto produto = new ControleProduto();

        public FrmProdView()
        {
            InitializeComponent();
        }

        public int id;
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            modelo.Id = id;
            modelo.Nome = txtNome.Text;
            modelo.preco = Convert.ToDecimal(txtpreco.Text);
            modelo.foto = lblfoto.Text;
            modelo.ctg = cbctg.SelectedIndex + 1;
            produto.Editar(modelo);
            this.Close();
        }

        private void AlterarImg(object sender, EventArgs e)
        {
            try
            {
                //chamo a caixa de dialogo para foto
                OpenFileDialog foto = new OpenFileDialog();
                foto.Filter = "Image File(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                //verifica se apertou no OK do dialog
                if (foto.ShowDialog() == DialogResult.OK)
                { //mostra o nome da foto
                    lblfoto.Text = foto.FileName;
                    //caminho da imagem para ser exibida no form
                    Image arquivo = Image.FromFile(foto.FileName);
                    ptbfoto.Image = arquivo;//carrego a foto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

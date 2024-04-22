using Controle;
using Guna.UI.Animation;
using Modelo;
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
    public partial class FrmCadastroProdView : Form
    {
        ModeloProduto pmodelo = new ModeloProduto();
        ControleProduto pController = new ControleProduto();
        public FrmCadastroProdView()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
          
                //instanciar o objeto produto
                try
                {
                    pmodelo.Nome = txtNome.Text;
                    pmodelo.preco = Convert.ToDecimal(txtpreco.Text);
                    pmodelo.foto = lblfoto.Text;
                    pmodelo.ctg = cbctg.SelectedIndex + 1;
                if (pController.cadastrarProduto(pmodelo) == true)
                {
                    MessageBox.Show("Cadastro com sucesso");
                    this.Close();
                }
                else
                    MessageBox.Show("Erro no cadastro");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

        private void ptbfoto_Click(object sender, EventArgs e)
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
                    lblfoto.Visible = false;
                    Image arquivo = Image.FromFile(foto.FileName);
                    ptbfoto.Image = arquivo;//carrego a foto
                }
                else
                {
                    MessageBox.Show("Não escolheu a foto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void FrmCadastroProd_Load(object sender, EventArgs e)
        {

        }

    }
    }


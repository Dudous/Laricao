using Controle;
using Correios;
using Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laricão.View
{
    public partial class FrmCarrinhoView : Form
    {
        public FrmCarrinhoView(PedidoModelo modelo, List<int> listquantidade)
        {
            InitializeComponent();
            this.quantidade = listquantidade;
            this.modelo = modelo;
        }
        List<int> quantidade = new List<int>();
        PedidoModelo modelo = new PedidoModelo();
        ControleProduto controle = new ControleProduto();
        int id = UsuarioControle.id;

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            var correio = new CorreiosApi();
            if (String.IsNullOrEmpty(txtCEP.Text))
            {
                txtCEP.BackColor = Color.LightCoral;
            }
            else
            {
                try
                {
                    correio.consultaCEP(txtCEP.Text);
                    var dados = correio.consultaCEP(txtCEP.Text);
                    txtEnd.Text = dados.end;
                    txtBairro.Text = dados.bairro;
                    txtCEP.BackColor = Color.White;
                    txtNum.Focus();
                }
                catch
                {
                    txtCEP.BackColor = Color.LightCoral;
                }
            }
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (cboPag.SelectedItem != null)
            {
                // Atribua o valor selecionado à propriedade Nome do modelo
                modelo.pag = cboPag.SelectedIndex + 1;

                if (TextBoxVazias())
                    MessageBox.Show("Preencha todos os Campos");
                else
                {
                    modelo.Nome = txt_nome.Text;
                    modelo.idusuario = id;
                    modelo.cep = txtCEP.Text;
                    modelo.bairro = txtBairro.Text;
                    modelo.end = txtEnd.Text;
                    modelo.num = txtNum.Text;
                    modelo.tel = txtTelefone.Text;
                    modelo.status = "Pedido Registrado - Aguardando Confirmação";
                    modelo.obs = txtobs.Text;

                    if (controle.CadastrarPedido(modelo))
                    {
                        MessageBox.Show("Pedido Enviado - Aguardando Confirmação");
                        controle.gerarPDF(modelo, quantidade);
                        this.Close();  
                    }
                    else
                        MessageBox.Show("Erro ao Enviar Pedido");
                }
            }
            else
            {
                // Trate o caso em que nenhum item está selecionado na ComboBox
                MessageBox.Show("Selecione um item na ComboBox.");
            }

        }

        private void BtnCalcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

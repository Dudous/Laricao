using Controle;
using Modelo;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;

namespace Laricão
{
    public partial class FrmCarrinho : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        int id;
        List<int> quantidade = new List<int> { 1, 1, 1, 1, 1, 1, 1 };
        decimal valor, valorProd;
        string table = "select carrinho.cod_prod, amburge.nome, amburge.preco, amburge.foto, categoria.categoria from carrinho inner join amburge on carrinho.cod_prod = amburge.id inner join categoria on amburge.categoria = categoria.id";
        Conexao con = new Conexao();
        ControleProduto controle = new ControleProduto();
        PedidoModelo modelo = new PedidoModelo();
        DataTable dt = new DataTable();
        List<ModeloProduto> produtos = new List<ModeloProduto>();

        public FrmCarrinho()
        {
            id = UsuarioControle.id;
            InitializeComponent();
        }

        private void FrmCarrinho_Load(object sender, EventArgs e)
        {
            pfc.AddFontFile("E:\\Laricao\\img\\Gluten.ttf");
            Font padrao = new Font(pfc.Families[0], 16, FontStyle.Regular);
            ListarProduto(table);
        }

        private void ListarProduto(string ctg)
        {
            pfc.AddFontFile("E:\\laricao\\img\\Gluten.ttf");
            dt = con.ObterDados(ctg);
            int x = 20;
            int y = 5;
            cartPanel.Controls.Clear();
            produtos.Clear();
            if (dt.Rows.Count > 0)
            {
                for (int registros = 0; registros < dt.Rows.Count; registros++)
                {
                    Label id = new Label();
                    id.Name = "id";
                    id.Text = registros.ToString();

                    Label cod = new Label();
                    cod.Name = "cod";
                    cod.Text = dt.Rows[registros][0].ToString();

                    Panel produto = new Panel();
                    produto.Controls.Clear();
                    produto.BorderStyle = BorderStyle.FixedSingle;
                    produto.Location = new Point(x, y);
                    produto.Height = 125;
                    produto.Width = 1175;

                    PictureBox foto = new PictureBox();
                    foto.Location = new Point(5, 5);
                    foto.SizeMode = PictureBoxSizeMode.StretchImage;
                    foto.Name = "foto";
                    foto.Image = Image.FromFile(dt.Rows[registros][3].ToString());
                    foto.Height = 115;
                    foto.Width = 115;

                    Label rs = new Label();
                    rs.Name = "rs";
                    rs.Text = "R$";
                    rs.Width = 30;
                    rs.Location = new Point(730, 60);
                    rs.Font = new Font(pfc.Families[0], 11, FontStyle.Bold);

                    Label preco = new Label();
                    preco.Name = "preco";
                    preco.Text = dt.Rows[registros][2].ToString();
                    preco.Location = new Point(770, 60);
                    preco.Font = new Font(pfc.Families[0], 11, FontStyle.Bold);

                    Label descproduto = new Label();
                    descproduto.Width = 200;
                    descproduto.Name = "nome";
                    descproduto.Text = dt.Rows[registros][1].ToString();
                    descproduto.Location = new Point(260, 40);
                    descproduto.Font = new Font(pfc.Families[0], 13, FontStyle.Bold);

                    Label categoria = new Label();
                    categoria.Name = "categoria";
                    categoria.Text = dt.Rows[registros][4].ToString();
                    categoria.Location = new Point(270, 70);
                    categoria.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);

                    TextBox qtd = new TextBox();
                    qtd.Width = 40;
                    qtd.Text = quantidade[registros].ToString();
                    qtd.TextAlign = HorizontalAlignment.Center;
                    qtd.Name = "Quantidade";
                    qtd.Leave += new EventHandler((sender1, e1) => QuantLeave(sender1, e1, qtd.Text, Convert.ToInt32(id.Text)));
                    qtd.Location = new Point(500, 60);

                    Button remover = new Button();
                    remover.Name = "Remover";
                    remover.Image = Image.FromFile("E:\\Laricao\\Laricão\\Resources\\trash.png");
                    remover.FlatStyle = FlatStyle.Flat;
                    remover.ImageAlign = ContentAlignment.MiddleLeft;
                    remover.Size = new Size(40, 40);
                    remover.FlatAppearance.BorderSize = 0;
                    remover.Click += new EventHandler((sender1, e1) => removerClick(sender1, e1, Convert.ToInt32(cod.Text)));
                    remover.Location = new Point(1000, 45);

                    produto.Controls.Add(descproduto);
                    produto.Controls.Add(rs);
                    produto.Controls.Add(preco);
                    produto.Controls.Add(foto);
                    produto.Controls.Add(remover);
                    produto.Controls.Add(categoria);
                    produto.Controls.Add(qtd);

                    //adiciono o painel produto ao painel
                    cartPanel.Controls.Add(produto);
                    y += 135;

                    //somo o valor total do carrinho
                    valorProd = quantidade[registros] * Convert.ToDecimal(dt.Rows[registros][2]);
                    valor += valorProd;

                    //
                    produtos.Add(new ModeloProduto()
                    {
                        Id = Convert.ToInt32(cod.Text),
                        Nome = descproduto.Text,
                        qtd = Convert.ToInt32(qtd.Text),
                        preco = Convert.ToDecimal(preco.Text)
                    });

                }

                lblValor.Text = valor.ToString();
                valorProd = 0;
                valor = 0;
            }
            else
            {
                Label msg = new Label();
                msg.Name = "Carrinho Vazio";
                msg.Text = "Carrinho Vazio";
                msg.Width = 500;
                msg.Font = new Font(pfc.Families[0], 13, FontStyle.Bold);
                msg.Location = new Point(530, 305);
                cartPanel.Controls.Add(msg);

            }
        }

        private void QuantLeave(object sender, EventArgs e, string quant, int id)
        {
            quantidade[id] = Convert.ToInt32(quant);
            ListarProduto(table);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count != 0)
            {
                string Json = JsonConvert.SerializeObject(produtos);
                modelo.json = Json;
                View.FrmCarrinhoView v = new View.FrmCarrinhoView(modelo, quantidade);
                v.ShowDialog();
                con.Cls();
            }
            else
                MessageBox.Show("Carrinho Vazio");
        }
        private void removerClick(object sender, EventArgs e, int id)
        {
            controle.RemoverCart(id);
            ListarProduto(table);
        }

    }
}

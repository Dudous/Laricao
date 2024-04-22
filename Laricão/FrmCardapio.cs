using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;
using Correios.CorreiosServiceReference;
using Modelo;
using Microsoft.Win32;
using Org.BouncyCastle.Asn1.Cmp;

namespace Laricão
{
    public partial class FrmCardapio : Form
    {
        int perfiluser;
        Conexao con = new Conexao();
        ControleProduto controleProduto = new ControleProduto();
        PrivateFontCollection pfc = new PrivateFontCollection();
        DataTable dt = new DataTable();
        string table = "select *from amburge where status = 1 order by id asc";

        public FrmCardapio()
        {
            InitializeComponent();
            perfiluser = UsuarioControle.perfil;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo voltar ao menu?", "Laricão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmMenu Menu = new FrmMenu();

                this.Hide();
                Menu.ShowDialog();
            }
        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            ListarProduto(table);
        }
        private void ListarProduto(string ctg)
        {
            // define a fonte dos itens
            pfc.AddFontFile("E:\\Laricao\\img\\Gluten.ttf");

            Font padrao = new Font(pfc.Families[0], 16, FontStyle.Regular);

            btnamburge.Font = padrao;
            btntodes.Font = padrao;
            btnporcao.Font = padrao;
            btnsuco.Font = padrao;
            btnsbm.Font = padrao;
            dt = con.ObterDados(ctg);
            int registros;
            int x = 25;
            int y = 10;
            flowLayoutPanel1.Controls.Clear();

            for (registros = 1; registros < dt.Rows.Count; registros++) // Roda uma vez para cada item no cardápio
            {
                Panel produto = new Panel(); // cria o Panel do produto
                string idproduto = dt.Rows[registros][0].ToString();
                produto.Controls.Clear();
                produto.BorderStyle = BorderStyle.FixedSingle;
                produto.Location = new Point(x, y);
                produto.Height = 340;
                produto.Width = 220;
                produto.BackColor = Color.White;

                PictureBox foto = new PictureBox(); // configura a foto do produto
                foto.Location = new Point(0, 0);
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][3].ToString());
                foto.Height = 220;
                foto.Width = 220;

                Label preco = new Label(); // configura o texto de preço
                preco.Name = "preco";
                preco.Text = "R$" + dt.Rows[registros][2].ToString();
                preco.Location = new Point(20, 270);
                preco.Font = new Font("Arial", 9, FontStyle.Regular);

                Label descproduto = new Label(); // configura o texto de título do produto
                descproduto.Name = "nome";
                descproduto.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
                descproduto.Text = dt.Rows[registros][1].ToString();
                descproduto.Width = Width;
                descproduto.Location = new Point(20, 235);

                Button registrar = new Button(); // configura o botão de 'Adicionar ao carrinho'
                registrar.Name = "Adicionar";
                registrar.Text = "Adicionar ao Carrinho";
                registrar.Font = new Font("Arial", 8, FontStyle.Bold);
                registrar.Click += new EventHandler((sender1, e1) => selecionarClick(sender1, e1, perfiluser, Convert.ToInt32(idproduto)));
                registrar.Location = new Point(20, 295);
                registrar.Height = 35;
                registrar.Width = 180;
                registrar.BackColor = Color.FromArgb(151, 143, 255);
                registrar.FlatStyle = FlatStyle.Flat;
                registrar.ForeColor = Color.White;
                
                int borderRadius = 9; // Ajuste o valor para controlar o raio do botão arredondado

                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, 2 * borderRadius, 2 * borderRadius, 180, 90); // Canto superior esquerdo
                path.AddArc(registrar.Width - 2 * borderRadius, 0, 2 * borderRadius, 2 * borderRadius, 270, 90); // Canto superior direito
                path.AddArc(registrar.Width - 2 * borderRadius, registrar.Height - 2 * borderRadius, 2 * borderRadius, 2 * borderRadius, 0, 90); // Canto inferior direito
                path.AddArc(0, registrar.Height - 2 * borderRadius, 2 * borderRadius, 2 * borderRadius, 90, 90); // Canto inferior esquerdo

                registrar.Region = new Region(path);

                // adiciona os items ao Panel produto
                produto.Controls.Add(descproduto);
                produto.Controls.Add(preco);
                produto.Controls.Add(foto);
                produto.Controls.Add(registrar);

                //adiciono o painel produto ao painel
                flowLayoutPanel1.Controls.Add(produto);
                //somando 100 a y
                x += 235;
                if (registros %5 == 0)
                {
                    x = 25;
                    y += 350;
                }
            }
        }
        private void selecionarClick(object sender, EventArgs e, int idperfil, int id) // Botão 'Adicionar' produto ao carrinho
        {
            List<int> val = con.Validacao("Select * from carrinho");
            if (!val.Contains(id)) // valida se o produto já não está no carrinho
            {
                if (controleProduto.CadastrarCart(id)) // chama a função que adiciona o produto ao carrinho
                    MessageBox.Show("Produto Adicionado ao Carrinho");
                else
                    MessageBox.Show("Carrinho Cheio!");
            }
            else
            {
                MessageBox.Show("Produto Já Adicionado ao Carrinho");
            }
        }

        // filtros de produtos
        private void btntodes_Click(object sender, EventArgs e)
        {
            table = "select *from amburge where status = 1 order by id asc";
            ListarProduto(table);
        }

        private void btnamburge_Click(object sender, EventArgs e)
        {
              table = "select *from amburge where status = 1 and categoria = 1 or categoria = 0 order by id asc";
              ListarProduto(table);
        }

        private void btnsuco_Click(object sender, EventArgs e)
        {
            table = "select *from amburge where status = 1 and categoria = 2 or categoria = 0 order by id asc";
            ListarProduto(table);
        }

        private void btnporcao_Click(object sender, EventArgs e)
        {
            table = "select *from amburge where status = 1 and categoria = 3 or categoria = 0 order by id asc";
            ListarProduto(table);
        }

        private void btnsbm_Click(object sender, EventArgs e)
        {
            table = "select *from amburge where status = 1 and categoria = 4 or categoria = 0 order by id asc";
            ListarProduto(table);
        }
    }
}

using Controle;
using Laricão.View;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laricão
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }
        Conexao con = new Conexao();
        ControleProduto produto = new ControleProduto();

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            string qry = "Select amburge.id, amburge.nome, amburge.preco, categoria.categoria, amburge.foto from amburge INNER JOIN categoria on amburge.categoria = categoria.id where amburge.id >= 2 and status = 1 order by amburge.nome";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvnome);
            lb.Items.Add(dgvpreco);
            lb.Items.Add(dgvctg);
            lb.Items.Add(dgvfoto);

            con.LoadData(qry, dgprod, lb);
        }

        private void dgprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgprod.CurrentCell.OwningColumn.Name == "dgvdelete")
            {
                DialogResult excluir = MessageBox.Show("Tem certeza que deseja excluir este Produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                int id = Convert.ToInt32(dgprod.CurrentRow.Cells["dgvid"].Value);
                if (excluir == DialogResult.Yes)
                {
                    produto.Excluir(id);
                    MessageBox.Show("Produto Deletado");
                    GetData();
                }
            }
            if (dgprod.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                int ctg = 2;
                FrmProdView prodview = new FrmProdView();
                prodview.id = Convert.ToInt32(dgprod.CurrentRow.Cells["dgvid"].Value);
                prodview.txtNome.Text = Convert.ToString(dgprod.CurrentRow.Cells["dgvnome"].Value);
                prodview.txtpreco.Text = Convert.ToString(dgprod.CurrentRow.Cells["dgvpreco"].Value);
                prodview.cbctg.Text = Convert.ToString(dgprod.CurrentRow.Cells["dgvctg"].Value);

                switch (prodview.cbctg.Text)
                {
                    case "Hambúrguer":
                        ctg = 0;
                        break;
                    case "Bebidas":
                        ctg = 1;
                        break;
                    case "Porções":
                        ctg = 2;
                        break;
                    case "Sobremesas":
                        ctg = 3;
                        break;
                }

                prodview.cbctg.SelectedIndex = ctg;
                prodview.lblfoto.Text = Convert.ToString(dgprod.CurrentRow.Cells["dgvfoto"].Value);
                prodview.ptbfoto.ImageLocation = Convert.ToString(dgprod.CurrentRow.Cells["dgvfoto"].Value);

                prodview.ShowDialog();
                GetData();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadastroProdView cadastro = new FrmCadastroProdView();
            cadastro.ShowDialog();
            GetData();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Pesquisarr();
        }
        public void Pesquisarr()
        {

           string qry = $"Select amburge.id, amburge.nome, amburge.preco, categoria.categoria, amburge.foto from amburge INNER JOIN categoria on amburge.categoria = categoria.id where amburge.nome like '%{txtPesquisar.Text}%' and amburge.id >= 2 order by amburge.nome";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvnome);
            lb.Items.Add(dgvpreco);
            lb.Items.Add(dgvctg);
          

            con.LoadData(qry, dgprod, lb);
        }

    }
}

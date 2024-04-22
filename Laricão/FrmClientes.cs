using Controle;
using Laricão.View;
using Modelo;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Laricão
{
    public partial class FrmClientes : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        UsuarioModelo modelo = new UsuarioModelo();
        UsuarioControle controle = new UsuarioControle();
        Conexao con = new Conexao();
        int id;
        public FrmClientes()
        {
            InitializeComponent();
            id = UsuarioControle.id;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            GetData();
            pfc.AddFontFile("E:\\laricao\\img\\Gluten.ttf");
            dtClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public void GetData()
        {
            string qry = "Select usuario.idusuario, usuario.nome, usuario.sobrenome, usuario.cpf, usuario.telefone, perfil.perfil, usuario.email from usuario inner join perfil on usuario.id_perfil = perfil.id_perfil where usuario.status = 1";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvId);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvSobre);
            lb.Items.Add(dgvCpf);
            lb.Items.Add(dgvTel);
            lb.Items.Add(dgvPerfil);
            lb.Items.Add(dgvEmail);

            con.LoadData(qry, dtClientes, lb);
        }

        private void dtClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtClientes.CurrentCell.OwningColumn.Name == "dgvDelete")
            {
                int id = Convert.ToInt32(dtClientes.CurrentRow.Cells["dgvId"].Value);
                if (id == UsuarioControle.id)
                    MessageBox.Show("Não é possível Excluir à Si Mesmo");
                else
                {
                    DialogResult excluir = MessageBox.Show("Tem certeza que deseja excluir este Usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (excluir == DialogResult.Yes)
                    {
                        controle.Excluir(id);
                        MessageBox.Show("Usuário Deletado");
                        GetData();
                    }
                }
            }
            if (dtClientes.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                FrmClientView clientview = new FrmClientView();
                clientview.id = Convert.ToInt32(dtClientes.CurrentRow.Cells["dgvId"].Value);
                clientview.txtnome.Text = Convert.ToString(dtClientes.CurrentRow.Cells["dgvName"].Value);
                clientview.txtsobre.Text = Convert.ToString(dtClientes.CurrentRow.Cells["dgvSobre"].Value);
                clientview.txtcpf.Text = Convert.ToString(dtClientes.CurrentRow.Cells["dgvCpf"].Value);
                clientview.txttel.Text = Convert.ToString(dtClientes.CurrentRow.Cells["dgvTel"].Value);
                clientview.cbperfil.Text = Convert.ToString(dtClientes.CurrentRow.Cells["dgvPerfil"].Value);
                clientview.txtemail.Text = Convert.ToString(dtClientes.CurrentRow.Cells["dgvEmail"].Value);
                clientview.ShowDialog();
                GetData();
            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            FrmCadastar cadastro = new FrmCadastar();
            cadastro.ShowDialog();
            GetData();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }


        public void Pesquisar()
        {
            string qry = $"Select usuario.idusuario, usuario.nome, usuario.sobrenome, usuario.cpf, usuario.telefone, perfil.perfil, usuario.email from usuario inner join perfil on usuario.id_perfil = perfil.id_perfil where nome like '%{txtPesquisar.Text}%' and usuario.status = 1";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvId);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvSobre);
            lb.Items.Add(dgvCpf);
            lb.Items.Add(dgvTel);
            lb.Items.Add(dgvPerfil);
            lb.Items.Add(dgvEmail);

            con.LoadData(qry, dtClientes, lb);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }

}
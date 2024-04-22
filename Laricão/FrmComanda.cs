using Controle;
using Correios.CorreiosServiceReference;
using Microsoft.VisualBasic.ApplicationServices;
using Modelo;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exception = System.Exception;

namespace Laricão
{
    public partial class FrmComanda : Form
    {
        Conexao con = new Conexao();
        ComandaModelo modelo = new ComandaModelo();
        DataTable dt = new DataTable();
        ControleProduto controle = new ControleProduto();
        public FrmComanda()
        {
            InitializeComponent();
        }

        private void FrmComanda_Load(object sender, EventArgs e)
        {
            CarregarDadosNaDataGridView();
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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (TextBoxVazias())
            {
                MessageBox.Show("Preencha todos os Campos");
            }
            else
            {
                modelo.Nome = txtNome.Text;
                modelo.Desc = txtDesc.Text;
                modelo.mesa = txtMesa.Text;

                // Chamar o método para enviar para o banco de dados
               
                InserirNoBancoDeDados(modelo);
            }
        }

     

        private void InserirNoBancoDeDados(ComandaModelo modelo)
        {
            try
            {

                // Abrir a conexão com o banco de dados

                MySqlConnection conn = con.GetConexao();
                conn.Open();


                // Montar a consulta SQL para inserção de dados
                string query = "INSERT INTO comanda (Nome, Descrical, Mesa) VALUES (@Nome, @Descrical, @Mesa)";

                // Criar o comando SQL e adicionar os parâmetros
                using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Nome", modelo.Nome);
                        command.Parameters.AddWithValue("@Descrical", modelo.Desc);
                        command.Parameters.AddWithValue("@Mesa", modelo.mesa);

                        // Executar a consulta
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados inseridos no banco de dados com sucesso!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados no banco de dados: " + ex.Message);
            }
        }
        private void CarregarDadosNaDataGridView()
        {
            try
            {
                // Abrir a conexão com o banco de dados
                MySqlConnection conn = con.GetConexao();
                conn.Open();

                // Montar a consulta SQL para selecionar todos os dados da tabela comanda
                string query = "SELECT * FROM comanda";

                // Criar o adaptador de dados e o conjunto de dados
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();

                    // Preencher o DataTable com os dados do banco de dados
                    adapter.Fill(dt);

                    // Vincular o DataTable à DataGridView
                    dtComanda.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados na DataGridView: " + ex.Message);
            }
        }


        private void dtComanda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

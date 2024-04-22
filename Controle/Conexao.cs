using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;


namespace Controle
{
    public class Conexao
    {
        static private string servidor = "localhost";
        static private string db = "laricao";
        static private string usuario = "root";
        static private string senha = "";
        public MySqlConnection con = null;
        Random aleatorio = new Random();

        static private string StrCon = "server=" + servidor + ";database=" + db + ";user=" + usuario + ";password=" + senha;

        public MySqlConnection GetConexao()
        {
            MySqlConnection conexao = new MySqlConnection(StrCon);
            return conexao;
        }
        public DataTable ObterDados(string sql) // Popula uma tabela com dados
        {
            //cria uma nova tabela de dados
            DataTable dt = new DataTable();
            MySqlConnection conn = GetConexao();
            conn.Open(); //Abre a Conexão
            MySqlCommand sqlCon = new MySqlCommand(sql, conn); //Cria uma linha de Comando SQL
            sqlCon.CommandType = System.Data.CommandType.Text;
            sqlCon.CommandText = sql;
            MySqlDataAdapter dados = new MySqlDataAdapter(sqlCon); //Monta as informações da consulta
            dados.Fill(dt);
            conn.Close();
            return dt;
        }

        public string getMD5Hash(string senha) // Criptografa a Senha
        {
            System.Security.Cryptography.MD5 mD5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(senha);
            byte[] hash = mD5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public string recuperaremail(string login)
        {
            try
            {
                DataTable dt = new DataTable();
                string msg = null;
                string senhanova;//guarda a senha gerada
                bool confirmar;//guarda o resultado do editar
                if (login == null)
                {//valida o preenchimento do campo 'login'
                    msg = "Preencha o campo 'Login'";
                }
                else
                {
                    //abrir o BD
                    con = GetConexao();
                    con.Open();
                    dt = ObterDados("select * from usuario where email ='" + login + "'"); // Obtém os dados do usuário

                    if (dt.Rows.Count > 0) // Se o Usuário for encontrado
                    {
                        string email = "eduardo-sampaio@outlook.com";
                        string senha = "coxinha123";

                        SmtpClient cliente = new SmtpClient();
                        cliente.Host = "smtp.office365.com";
                        cliente.Port = 587;
                        cliente.EnableSsl = true;
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new System.Net.NetworkCredential(email, senha);
                        cliente.DeliveryMethod = SmtpDeliveryMethod.Network;

                        // Configura as informações do E-mail
                        MailMessage mail = new MailMessage();
                        mail.Sender = new MailAddress(email, "Laricão Hamburgueria");
                        mail.From = new MailAddress(email, "Recuperar senha");
                        string emailusuario = dt.Rows[0][7].ToString();
                        mail.To.Add(new MailAddress(emailusuario, dt.Rows[0][1].ToString()));
                        mail.Subject = "Recuperar Senha";
                        senhanova = aleatorio.Next(2000).ToString();

                        UsuarioModelo modelo = new UsuarioModelo();
                        UsuarioControle controle = new UsuarioControle();
                        // Populo meu modelo para Editar a Senha
                        modelo.senha = senhanova;
                        modelo.id = Convert.ToInt32(dt.Rows[0][0].ToString());
                        modelo.nome = dt.Rows[0][1].ToString();
                        modelo.sobrenome = dt.Rows[0][2].ToString();
                        modelo.cpf = dt.Rows[0][3].ToString();
                        modelo.tel = dt.Rows[0][4].ToString();
                        modelo.idperfil = Convert.ToInt32(dt.Rows[0][6].ToString());
                        modelo.email = dt.Rows[0][7].ToString();
                        // Chama a função para editar a senha do Usuário
                        confirmar = controle.Editar(modelo);
                        // Defino o Texto no corpo do E-mail
                        mail.Body = "Olá " + dt.Rows[0][1].ToString() + " sua senha é: " + senhanova;
                        mail.IsBodyHtml = true;//cria um arquivo html
                        try
                        {
                            if (confirmar) // Valida a Edição da Senha
                            {
                                cliente.SendMailAsync(mail); // Envia o E-Mail
                                msg = "E-mail enviado com a nova senha";
                            }
                            else
                            {
                                msg = "não foi possivel atualizar senha";
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Erro ao enviar o email:" + ex.Message);
                        }
                    }
                    else
                    {
                        msg = "Usuário não localizado";
                    }
                }
                return msg;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:" + ex.Message);
            }

        }
        public void AttStatus(int status, int id) // Altera o Status do Pedido 
        {
            try
            {
                string msg = null;
                string user = null;
                string name;

                switch (status)
                {
                    case 1:
                        msg = "Seu Pedido foi aceito e está sendo Preparado!";
                        break;
                    case 2:
                        msg = "Seu Pedido foi Recusado!";
                        break;
                    case 3:
                        msg = "Pedido Finalizado, sendo enviado para Entrega!!";
                        break;
                }

                MySqlConnection con = GetConexao();
                con.Open();//abre o banco de dados
                string command = $"select email, nome from usuario where idusuario= {id}";
                MySqlCommand sqlCon = new MySqlCommand(command, con);
                sqlCon.CommandType = CommandType.Text;
                sqlCon.CommandText = command;

                MySqlDataReader query = sqlCon.ExecuteReader();
                if (query.Read())
                {
                    query.Read();
                    user = query["email"].ToString();
                    name = query["nome"].ToString();
                }
                con.Close();

                string email = "eduardo-sampaio@outlook.com";
                string senha = "coxinha123";

                SmtpClient cliente = new SmtpClient();
                cliente.Host = "smtp.office365.com";
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new System.Net.NetworkCredential(email, senha);
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;


                MailMessage mail = new MailMessage();
                mail.Sender = new MailAddress(email, "Laricão Hamburgueria");
                mail.From = new MailAddress(email, "Laricão hamburgueria");
                mail.To.Add(new MailAddress(user));
                mail.Subject = "Status Pedido";
                mail.Body = msg;
                mail.IsBodyHtml = true;//cria um arquivo html
                try
                {
                    cliente.SendMailAsync(mail);

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao enviar o email:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:" + ex.Message);
            }

        }
        public List<int> Validacao(string sql) // Retorna os itens do Carrinho em formato de List
        {
            MySqlConnection conn = GetConexao();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<int> valores = new List<int>();
            while (reader.Read())
            {
                int valor = Convert.ToInt32(reader["cod_prod"]);
                valores.Add(valor);
            }

            reader.Close();
            conn.Close();
            return valores;
        }
        public bool ValidaCadastro(string email, string cpf) // Valida se o e-mail ou cpf já está cadastrado
        {
            bool resultado = false;
            string sqlComando = $"select Count(*) from usuario where cpf = '{cpf}' or email = '{email}'";

            MySqlConnection sqlConexao = GetConexao();
            sqlConexao.Open();
            MySqlCommand cmd = new MySqlCommand(sqlComando, sqlConexao);

            if (Convert.ToInt32(cmd.ExecuteScalar()) >= 1)
                resultado = true;

            sqlConexao.Close();

            return resultado;
        }
        public bool Cls() // Limpa o banco de dados do Carrinho
        {
            bool resultado = false;
            string command = "truncate table carrinho";

            MySqlConnection con = GetConexao();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(command, con);

            if (cmd.ExecuteNonQuery() >= 1)
                resultado = true;

            con.Close();

            return resultado;
        }

        public void LoadData(string qry, DataGridView dv, ListBox lb) // Popula as tabelas de Clientes e Produtos
        {
                MySqlConnection con = GetConexao(); 
            try
            {
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for(int i = 0; i < lb.Items.Count; i++) // Define os dados para suas tabelas pré definidas
                {
                    string colName = ((DataGridViewColumn)lb.Items[i]).Name;
                    dv.Columns[colName].DataPropertyName = dt.Columns[i].ToString();
                }

                dv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

    }
}

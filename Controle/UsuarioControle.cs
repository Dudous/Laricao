using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Controle
{
    public class UsuarioControle
    {
        Conexao con = new Conexao();

        public bool logar(UsuarioModelo login) // Valida as informações do usuário para efetuar o login
        {
            DataTable dt = new DataTable(); // cria uma tabela
            bool valid = false;
            string sql = "select idusuario,id_perfil,status from usuario where email = @usuario and senha = @senha";
            MySqlConnection sqlConexao = con.GetConexao();
            sqlConexao.Open();
            MySqlCommand cmd = new MySqlCommand(sql, sqlConexao); // configura o comando sql
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@usuario", login.email);
            cmd.Parameters.AddWithValue("@senha", con.getMD5Hash(login.senha));
            if (Convert.ToInt32(cmd.ExecuteScalar()) >= 1) // usuario validado
            {
                MySqlDataAdapter dados = new MySqlDataAdapter(cmd);
                dados.Fill(dt);
                if (Convert.ToInt32(dt.Rows[0][2]) == 1)
                    valid = true;
                // Define as informações do Usuário de maneira global
                UsuarioControle.id = Convert.ToInt32(dt.Rows[0][0]);
                UsuarioControle.perfil = Convert.ToInt32(dt.Rows[0][1]);
            }
            sqlConexao.Close();
            return valid;
        }


        public bool teste() // utilizado para testes de conexao
        {
            if (con.GetConexao() == null)
                return false;
            else
                return true;
        }

        public bool Cadastrar(UsuarioModelo usuario) // Cadastra um novo Usuário
        {
            bool resultado = false;
            string sqlComando = $"INSERT INTO usuario (nome, sobrenome, cpf, telefone, senha, id_perfil, email) VALUES ('{usuario.nome}','{usuario.sobrenome}','{usuario.cpf}','{usuario.tel}','{con.getMD5Hash(usuario.senha)}','{usuario.idperfil}','{usuario.email}')";

            MySqlConnection sqlConexao = con.GetConexao();
            sqlConexao.Open();
            MySqlCommand cmd = new MySqlCommand(sqlComando, sqlConexao);
            if (cmd.ExecuteNonQuery() >= 1)
                resultado = true;

            sqlConexao.Close();
            return resultado;
        }
        public bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(",", "").Replace("-", ""); // remove as vírgulas e os traços deixando apenas os números

            if (cpf.Length != 11 || TodosDigitosIguais(cpf)) // verifica se não são digitos iguais e se estão na quantidade certa
            {
                return false;
            }

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++) // transforma a string cpf em uma array de ints
            {
                if (!int.TryParse(cpf[i].ToString(), out numeros[i]))
                {
                    return false;
                }
            }

            int soma1 = 0;
            for (int i = 0; i < 11; i++) // soma todos os Ints do array
            {
                soma1 += numeros[i];
            }

            int resto1 = soma1 % 11; // verifica se a soma é divisível por 11 (obrigatório para ser um CPF)

            if (resto1 == 0)
                return true;
            else
                return false;
        }
        static bool TodosDigitosIguais(string cpf) // Verifica se todos os Dígitos de uma string são iguais
        {
            bool result = false;
            for (int i = 1; i < cpf.Length; i++)
            {
                if (cpf[i] != cpf[0])
                {
                    result = false;
                }
                else
                    result = true;
            }
            return result;
        }
        public bool Editar(UsuarioModelo us) // edita as informações de um usuário
        {
            bool resultado = false;
            string sql = null;
            if (us.senha == null) // validação para o caso de troca de senha (não obrigatório na edicão do usuário)
                sql = "update usuario set nome = @nome, sobrenome = @sobrenome, cpf = @cpf, telefone = @telefone, id_perfil = @perfil, email = @email where idusuario = @id";
            else
                sql = "update usuario set nome = @nome, sobrenome = @sobrenome, senha = @senha, cpf = @cpf, telefone = @telefone, id_perfil = @perfil, email = @email where idusuario = @id";
            MySqlConnection sqlConexao = con.GetConexao();
            sqlConexao.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlConexao);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            //substituindo a variavel @___ pelo conteúdo do objeto
            command.Parameters.AddWithValue("@nome", us.nome);
            command.Parameters.AddWithValue("@sobrenome", us.sobrenome);
            command.Parameters.AddWithValue("@cpf", us.cpf);
            command.Parameters.AddWithValue("@telefone", us.tel);
            command.Parameters.AddWithValue("@id", us.id);
            command.Parameters.AddWithValue("@perfil", us.idperfil);
            command.Parameters.AddWithValue("@email", us.email);
            if (us.senha != null) // inserir a senha criptografada no caso de alteração
                command.Parameters.AddWithValue("@senha", con.getMD5Hash(us.senha));
            if (command.ExecuteNonQuery() >= 1)
                resultado = true;
            sqlConexao.Close();
            return resultado;
        }

        public bool Excluir(int id) // altera o status do Usuário para 'inativo'
        {
            bool resultado = false;
            string sql = "UPDATE usuario SET status = 2 WHERE usuario.idusuario = " + id;
            MySqlConnection sqlConexao = con.GetConexao();
            sqlConexao.Open();
            MySqlCommand Command = new MySqlCommand(sql, sqlConexao);
            Command.CommandType = System.Data.CommandType.Text;
            Command.CommandText = sql;
            if (Command.ExecuteNonQuery() >= 1)
                resultado = true;
            sqlConexao.Close();
            return resultado;
        }

        // Define as Variáveis utilizadas por todo o Sistema

        public static int id;
        public static int ID
        {
            get { return id; }
            private set { id = value; }
        }
        public static int perfil;
        public static int PERFIL
        {
            get { return perfil; }
            private set { perfil = value; }
        }

    }
}


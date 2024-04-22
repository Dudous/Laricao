using Modelo;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Controle
{
    public class ControleProduto
    {
        Conexao con = new Conexao();
        public bool CadastrarCart(int produto) // Insere os Itens no carrinho
        {
            bool resultado = false;
            DataTable cart = con.ObterDados("select *from carrinho");
            if (cart.Rows.Count < 7)
            {
                string sqlComando = "INSERT INTO carrinho (cod_prod) VALUES ('" + produto + "')";

                MySqlConnection sqlConexao = con.GetConexao();
                sqlConexao.Open();
                MySqlCommand cmd = new MySqlCommand(sqlComando, sqlConexao);

                if (cmd.ExecuteNonQuery() >= 1)
                    resultado = true;

                sqlConexao.Close();
            }

            return resultado;
        }
        public bool RemoverCart(int produto) // Remove os Itens do Carrinho
        {

            bool resultado = false;
            string sqlComando = "DELETE FROM `carrinho` WHERE `carrinho`.`cod_prod` = " + produto;

            MySqlConnection sqlConexao = con.GetConexao();
            sqlConexao.Open();
            MySqlCommand cmd = new MySqlCommand(sqlComando, sqlConexao);

            if (cmd.ExecuteNonQuery() >= 1)
                resultado = true;

            sqlConexao.Close();

            return resultado;
        }
        public bool CadastrarPedido(PedidoModelo pedido) // Insere o Pedido no Banco de dados
        {
            bool resultado = false;

            string sqlComando = $"insert into pedidos (Nome, idusuario, cep, bairro, endereco, num, tel, status, pedido, obs, pagamento) values ('" +
                $"{pedido.Nome}','{pedido.idusuario}','{pedido.cep}','{pedido.bairro}','{pedido.end}','{pedido.num}','{pedido.tel}','{pedido.status}','{pedido.json}', '{pedido.obs}', '{pedido.pag}')";

            MySqlConnection sqlConexao = con.GetConexao();
            sqlConexao.Open();
            MySqlCommand cmd = new MySqlCommand(sqlComando, sqlConexao);

            if (cmd.ExecuteNonQuery() >= 1)
                resultado = true;

            sqlConexao.Close();

            return resultado;
        }
        public bool Editar(ModeloProduto mp) // edita as informações do produto
        {
            bool resultado = false;
            string sql = "update amburge set nome = @nome, preco= @preco, foto = @foto, categoria = @categoria where id = @id";
            MySqlConnection sqlConexao = con.GetConexao();
            sqlConexao.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlConexao);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            //substituindo a variavel @___ pelo conteúdo do objeto
            command.Parameters.AddWithValue("@id", mp.Id);
            command.Parameters.AddWithValue("@nome", mp.Nome);
            command.Parameters.AddWithValue("@preco", mp.preco);
            command.Parameters.AddWithValue("@foto", mp.foto);
            command.Parameters.AddWithValue("@categoria", mp.ctg);

            if (command.ExecuteNonQuery() >= 1)
                resultado = true;
            sqlConexao.Close();
            return resultado;
        }

        public string EditarStatus(int cod, int op) // Edita o Status do Pedido 
        {
            string msg = null;

            switch (op) // Define o texto com base no botão selecionado
            {
                case 1:
                    msg = "Pedido Aceito, Estamos Preparando seu Pedido!";
                    break;
                case 2:
                    msg = "Pedido Recusado";
                    break;
                case 3:
                    msg = "Pedido Finalizado";
                    break;
            }

            string sqlComando = $"Update pedidos set status = '{msg}' where id_pedido = {cod}";

            MySqlConnection sqlConexao = con.GetConexao();
            sqlConexao.Open();
            MySqlCommand cmd = new MySqlCommand(sqlComando, sqlConexao);

            cmd.ExecuteNonQuery();

            sqlConexao.Close();

            return msg;
        }

        public bool cadastrarProduto(ModeloProduto prod) // Cadastra um novo Produto
        {
            bool resultado = false;

            string sqlComando = $"insert into amburge (id, nome, preco, foto, categoria) values (@id, @nome, @preco,@foto, @categoria)";

            MySqlConnection sqlConexao = con.GetConexao();
            sqlConexao.Open();
            MySqlCommand cmd = new MySqlCommand(sqlComando, sqlConexao);
            cmd.Parameters.AddWithValue("@id", prod.Id);
            cmd.Parameters.AddWithValue("@nome", prod.Nome);
            cmd.Parameters.AddWithValue("@preco", prod.preco);
            cmd.Parameters.AddWithValue("@foto", prod.foto);
            cmd.Parameters.AddWithValue("@categoria", prod.ctg);

            if (cmd.ExecuteNonQuery() >= 1)
                resultado = true;

            sqlConexao.Close();

            return resultado;
        }
        public bool Excluir(int id) // Altera o Status do Produto para 'inativo'
        {
            bool resultado = false;
            string sql = "UPDATE amburge SET status = 2 WHERE amburge.id = " + id;
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
        public void gerarPDF(PedidoModelo modelo, List<int> qtd) // Gera a Nota Fiscal
        {
            string sql = "select carrinho.cod_prod, amburge.nome, amburge.preco from carrinho inner join amburge on carrinho.cod_prod = amburge.id";

            //preparo o comando sql
            MySqlConnection sqlConexao = con.GetConexao();
            UsuarioModelo us = new UsuarioModelo();
            ModeloProduto mp = new ModeloProduto();
            MySqlCommand cmd = new MySqlCommand(sql, sqlConexao);
            //define as medidas do documento
            XUnit pageWidth = XUnit.FromMillimeter(148);
            XUnit pageHeight = XUnit.FromMillimeter(210);
            PdfDocument pdfDocument = new PdfDocument();
            //define a imagem do QR Code
            XImage image = XImage.FromFile("E:\\Laricao\\img\\frame.png");
            XRect imageRect = new XRect(30, 30, 30, 30);

            MySqlDataAdapter dados;//preparar os dados
            DataSet ds = new DataSet();
            XFont font = new XFont("Arial", 12);
            double lineHeight = font.GetHeight();


            try //teste de consulta
            {
                int i = 0;//registro
                int ypoint = 0;//espaço do conteudo
                sqlConexao.Open();//abro a conexao
                dados = new MySqlDataAdapter(cmd);//recuperando as informações
                dados.Fill(ds);//carrega as informções geradas
                switch (ds.Tables[0].Rows.Count)
                {
                    case 1:
                        pageHeight = XUnit.FromMillimeter(200); // Altura da página para 1 pedido
                        break;
                    case 2:
                        pageHeight = XUnit.FromMillimeter(210); // Altura da página para 2 pedidos
                        break;
                    case 3:
                        pageHeight = XUnit.FromMillimeter(220); // Altura da página para 3 pedidos
                        break;
                    case 4:
                        pageHeight = XUnit.FromMillimeter(220); // Altura da página para 4 pedidos
                        break;
                    case 5:
                        pageHeight = XUnit.FromMillimeter(230); // Altura da página para 5 pedidos
                        break;
                    case 6:
                        pageHeight = XUnit.FromMillimeter(240); // Altura da página para 6 pedidos
                        break;
                    case 7:
                        pageHeight = XUnit.FromMillimeter(250); // Altura da página para 7 pedidos
                        break;
                    default:
                        // outros casos ou erros aqui, se necessário
                        break;



                }
                PdfDocument pdf = new PdfDocument();
                //chamo a instancia do PDf
                pdf.Info.Title = "Nota Fiscal"; // define o título do documento
                PdfPage page = pdf.AddPage();//gera uma nova pagina
                XGraphics grafic = XGraphics.FromPdfPage(page);
                page.Width = pageWidth;
                page.Height = pageHeight;
                //defino a font e o tamanho
                XPoint startPoint = new XPoint(160, 40);
                double tableStartY = startPoint.Y + lineHeight * 7;
                double tableY = tableStartY + lineHeight;
                grafic.DrawString("--------------------------------------------------------------------------------", font, XBrushes.Black, new XPoint(40, lineHeight * 4));
                grafic.DrawString("--------------------------------------------------------------------------------", font, XBrushes.Black, new XPoint(40, lineHeight * 8));
                grafic.DrawString("Nota Fiscal", font, XBrushes.Black, startPoint);
                grafic.DrawString($"Nome do Cliente: {modelo.Nome}", font, XBrushes.Black, new XPoint(40, lineHeight * 5));
                grafic.DrawString($"Rua: {modelo.end}, {modelo.num} - {modelo.bairro}", font, XBrushes.Black, new XPoint(40, lineHeight * 6));

                grafic.DrawString("Quantidade", font, XBrushes.Black, new XPoint(40, tableStartY));
                grafic.DrawString("Data: " + DateTime.Now.ToString(), font, XBrushes.Black, new XPoint(40, lineHeight * 7));
                grafic.DrawString("Descrição", font, XBrushes.Black, new XPoint(160, tableStartY));
                tableY = tableY + 30;
                grafic.DrawString("Valor Unitário", font, XBrushes.Black, new XPoint(315, tableStartY));
                ypoint = ypoint + 75;//nova posição
                decimal total = 0;
                for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    us.id = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    mp.preco = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    us.nome = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[1].ToString());

                    grafic.DrawString(qtd[i].ToString(), font, XBrushes.Black, new XPoint(43, tableY));
                    ypoint = ypoint + 30;
                    us.nome = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    grafic.DrawString(us.nome.ToString(), font, XBrushes.Black, new XPoint(160, tableY));
                    ypoint = ypoint + 30;
                    grafic.DrawString(mp.preco.ToString(), font, XBrushes.Black, new XPoint(315, tableY));
                    tableY = tableY + 30;
                    total += mp.preco * qtd[i];
                }


                // ...

                grafic.DrawImage(image, new XPoint(89, tableY + 5));
                double alturaDaImagem = 70; // Defina a altura real da sua imagem

                // Ajuste a coordenada Y das linhas de texto com base na altura da página
                double linhaY = pageHeight.Point - alturaDaImagem - font.Height * 1; // Posição das linhas de texto

                grafic.DrawString("Total: " + total, font, XBrushes.Black, new XPoint(160, linhaY));
                linhaY += font.Height;

                grafic.DrawString("Obrigado pela preferência", font, XBrushes.Black, new XPoint(130, linhaY));

                // ...


                string pdffilename = "Nota.pdf";
                pdf.Save(pdffilename);//salvo o arquivo em pdf
                Process.Start(pdffilename);//abro o arquivo salvo
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Modelo
{
    public class ModeloProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int qtd { get; set; }
        public decimal preco { get; set; }

        public int ctg { get; set; }

        public string foto { get; set; }

        public ModeloProduto()
        {
           
                //inicializando os valores default
                this.Id = 0;
                this.Nome = "";
                //   this.preco = 0;




            }
        //metodo de acesso as varivaies
        public int codigo
        {
            //obter dados da variavel
            get { return Id; }
            //alterar dados da variavel
            set { Id = value; }
        }
        public string descricao
        {
            get { return Nome; }
            set { Nome = value; }
        }

        public decimal precos
        {
            get { return preco; }
            set { preco = value; }
        }

        public string fotos
        {
            get { return foto; }
            set { foto = value; }
        }
    }
}

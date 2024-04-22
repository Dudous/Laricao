using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class ProdutoModelo
    {
        public int id { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }
        public string foto { get; set; }
        public string ctg { get; set; }
        public ProdutoModelo()
        {
            //inicializando os valores default
            this.id = 0;
            this.nome = "";
         //   this.preco = 0;

    


        }
        //metodo de acesso as varivaies
        public int codigo
        {
            //obter dados da variavel
            get { return id; }
            //alterar dados da variavel
            set { id = value; }
        }
        public string descricao
        {
            get { return nome; }
            set { nome = value; }
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




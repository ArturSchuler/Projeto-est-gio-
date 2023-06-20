using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Guinevere
{
    public class Carrinho
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Number { get; set; }
        public Cliente Cliente { get; set; } = new Cliente();
        public List<Produto> produtos { get; set; } = new List<Produto>();
        public int quantidade_prod { get; set; }
        public float Valor_total { get; set; }
        public DateTime Data { get; set; }
        
        public string Tipo_pag { get; set; }
        public int Id_cliente { get; set; }
        public int Id_desconto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Guinevere
{
    public class Produto 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Number { get; set; }
        public int SecId { get; set; }
        public double Valor { get; set; }
        public string Marca { get; set; }
        public string Resumo { get; set; }
        public string Detalhe { get; set; }
        public bool Servico { get; set; }
        public byte[] Foto { get; set; }
        public double Valor_original { get; set; }
    }
}
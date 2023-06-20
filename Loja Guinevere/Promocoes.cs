using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Guinevere
{
    public class Promocoes
    {
        public int Id { get; set; }
        public DateTime Dt_fim { get; set; }
        public DateTime Dt_inicio { get; set; }
        public int DescontoPerc { get; set; }
        public float DescontoValor { get; set; }
        public int Grau { get; set; }
        public float desc_valor { get; set; }
    }
}

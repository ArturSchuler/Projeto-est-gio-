using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Guinevere
{
    public class Secao : NomeProvisorio
    {
        public Setor SetorPertencente { get; set; }

        public Secao(int id, string name, int number, Setor setorPertencente)
            : base(id, name, number)
        {
            SetorPertencente = setorPertencente;
        }

        public static List<Secao> lista_secoes = new List<Secao>();

        public static void Cadastrar(Secao secao)
        {
            lista_secoes.Add(secao);
        }

        public static Secao Ver(int id)
        {
            return lista_secoes.Find(secao => secao.Id == id);
        }

        public static void Alterar(int id, string novoNome, int novoNumero, Setor novoSetor)
        {
            Secao secao = lista_secoes.Find(secao => secao.Id == id);

            if (secao != null)
            {
                secao.Name = novoNome;
                secao.Number = novoNumero;
                secao.SetorPertencente = novoSetor;
            }
        }

        public static void Excluir(int id)
        {
            Secao secao = lista_secoes.Find(secao => secao.Id == id);
            if (secao != null)
            {
                lista_secoes.Remove(secao);
            }
        }

        public Setor ObterSetor()
        {
            return SetorPertencente;
        }
    }
}

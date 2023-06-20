using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Guinevere
{
    public class Produto : NomeProvisorio
    {
        public int IdSecao { get; set; }
        public string Marca { get; set; }
        public float Valor { get; set; }
        public bool Servico { get; set; }
        public string Resumo { get; set; }
        public string Detalhes { get; set; }
        public string Foto { get; set; }

        public Produto(int id, string name, int number, int idSecao, string marca, float valor, bool servico, string resumo, string detalhes, string foto)
            : base(id, name, number)
        {
            IdSecao = idSecao;
            Marca = marca;
            Valor = valor;
            Servico = servico;
            Resumo = resumo;
            Detalhes = detalhes;
            Foto = foto;
        }

        public static List<Produto> lista_produtos = new List<Produto>();

        public static void Cadastrar(Produto produto)
        {
            lista_produtos.Add(produto);
        }

        public static Produto Ver(int id)
        {
            return lista_produtos.Find(produto => produto.Id == id);
        }

        public static void Alterar(int id, string novoNome, int novoNumero, int novoIdSecao, string novaMarca, float novoValor, bool novoServico, string novoResumo, string novosDetalhes, string novaFoto)
        {
            Produto produto = lista_produtos.Find(produto => produto.Id == id);

            if (produto != null)
            {
                produto.Name = novoNome;
                produto.Number = novoNumero;
                produto.IdSecao = novoIdSecao;
                produto.Marca = novaMarca;
                produto.Valor = novoValor;
                produto.Servico = novoServico;
                produto.Resumo = novoResumo;
                produto.Detalhes = novosDetalhes;
                produto.Foto = novaFoto;
            }
        }

        public static void Excluir(int id)
        {
            Produto produto = lista_produtos.Find(produto => produto.Id == id);
            if (produto != null)
            {
                lista_produtos.Remove(produto);
            }
        }

        public static List<Produto> ListaProd()
        {
            return lista_produtos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_Guinevere
{
    public class Departamento : NomeProvisorio
    {
        public Departamento(int id, string name, int number)
        {
            Id = id;
            Name = name;
            Number = number;
        }

        public static List<Departamento> lista_departamentos = new List<Departamento>();

        private static void Cadastrar(Departamento departamento)
        {
            lista_departamentos.Add(departamento);
        }

        public static Departamento Ver(int id)
        {
            return lista_departamentos.Find(departamento => departamento.Id == id);
        }

        private static void Alterar(int id, string novoNome, int novoNumero)
        {
            Departamento departamento = lista_departamentos.Find(departamento => departamento.Id == id);

            if (departamento != null)
            {
                departamento.Name = novoNome;
                departamento.Number = novoNumero;
            }
        }

        private static void Excluir(int id)
        {
            Departamento departamento = lista_departamentos.Find(departamento => departamento.Id == id);
            if (departamento != null)
            {
                lista_departamentos.Remove(departamento);
            }
        }
    }
}

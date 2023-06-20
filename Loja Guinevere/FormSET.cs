using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Guinevere
{
    public partial class FormSET : Form
    {
        public FormSET()
        {
            InitializeComponent();
            listViewSETOR.View = View.Details;

            // Adiciona as colunas.
            listViewSETOR.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listViewSETOR.Columns.Add("Id do Departamento", -2, HorizontalAlignment.Left);
            listViewSETOR.Columns.Add("Nome", -2, HorizontalAlignment.Left);
        }

        private void btnCADASTRARSETOR_Click(object sender, EventArgs e)
        {
            CRUD_Setor set = new CRUD_Setor();
            set.DepId = int.Parse(txtBxCAD_IDDEP.Text);
            set.Nome = txtBxCAD_NOMESETOR.Text;
            set.Cadastrar_setor();
            MessageBox.Show(set.mensagem);
        }

        private void btnALTERARSETOR_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBxALTER_IDSETOR.Text);
            CRUD_Setor set = new CRUD_Setor();
            set.Id = id;
            set.DepId = int.Parse(txtBxALTER_IDDEP.Text);
            set.Nome = txtBxALTER_NOMESETOR.Text;
            set.Alterar_setor(set);
            MessageBox.Show(set.mensagem);
        }

        private void btnEXCLUIRSETOR_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBxDEL_SETOR.Text);
            CRUD_Setor set = new CRUD_Setor();
            set.Id = id;
            set.Excluir_setor(id);
            MessageBox.Show(set.mensagem);
        }

        private void btnVERSETOR_Click(object sender, EventArgs e)
        {
            // Limpa o ListView para evitar duplicatas.
            listViewSETOR.Items.Clear();
            CRUD_Setor str = new CRUD_Setor();
            // Chama a função para obter a lista de departamentos.
            List<Setor> setores = str.Ver_setor();

            // Itera sobre os departamentos retornados.
            foreach (Setor set in setores)
            {
                // Cria um novo ListViewItem.
                ListViewItem item = new ListViewItem(set.Id.ToString());

                // Adiciona as subcolunas.
                item.SubItems.Add(set.DepId.ToString());
                item.SubItems.Add(set.Nome);
                // Adiciona o item ao ListView.
                listViewSETOR.Items.Add(item);
            }
        }
    }
}

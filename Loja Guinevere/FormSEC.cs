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
    public partial class FormSEC : Form
    {
        public FormSEC()
        {
            InitializeComponent();
            listViewSECAO.View = View.Details;

            // Adiciona as colunas.
            listViewSECAO.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listViewSECAO.Columns.Add("Id do Setor", -2, HorizontalAlignment.Left);
            listViewSECAO.Columns.Add("Nome", -2, HorizontalAlignment.Left);
        }

        private void btnCadastraSecao_Click(object sender, EventArgs e)
        {
            CRUD_Secao sec = new CRUD_Secao();
            sec.SetId = int.Parse(txtBxCAD_IDSET.Text);
            sec.Nome = txtBxCAD_NOMESecao.Text;
            sec.Cadastrar_Secao();
            MessageBox.Show(sec.mensagem);
        }

        private void btnAlteraSecao_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBxALTER_IDSecao.Text);
            CRUD_Secao sec = new CRUD_Secao();
            sec.Id = id;
            sec.SetId = int.Parse(txtBxALTER_IDSETOR_sec.Text);
            sec.Nome = txtBxALTER_NomeSecao.Text;
            sec.Alterar_Secao(sec);
            MessageBox.Show(sec.mensagem);
        }

        private void btnDeletaSecao_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBxDEL_Secao.Text);
            CRUD_Secao sec = new CRUD_Secao();
            sec.Id = id;
            sec.Excluir_Secao(id);
            MessageBox.Show(sec.mensagem);
        }

        private void btnVerSecao_Click(object sender, EventArgs e)
        {
            // Limpa o ListView para evitar duplicatas.
            listViewSECAO.Items.Clear();
            CRUD_Secao seco = new CRUD_Secao();
            // Chama a função para obter a lista de departamentos.
            List<Secao> secoes = seco.Ver_Secao();

            // Itera sobre os departamentos retornados.
            foreach (Secao sec in secoes)
            {
                // Cria um novo ListViewItem.
                ListViewItem item = new ListViewItem(sec.Id.ToString());

                // Adiciona as subcolunas.
                item.SubItems.Add(sec.SetId.ToString());
                item.SubItems.Add(sec.Nome);
                // Adiciona o item ao ListView.
                listViewSECAO.Items.Add(item);
            }
        }

        private void txtBxCAD_IDSET_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

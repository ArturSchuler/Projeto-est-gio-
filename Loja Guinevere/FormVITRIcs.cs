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
    public partial class FormVITRIcs : Form
    {
        public FormVITRIcs()
        {
            InitializeComponent();
            listViewVIT.View = View.Details;

            // Adiciona as colunas.
            listViewVIT.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listViewVIT.Columns.Add("Id do Produto", -2, HorizontalAlignment.Left);
        }

        private void buttonCADVIT_Click(object sender, EventArgs e)
        {
            CRUD_Vitrine vit = new CRUD_Vitrine();
            vit.Prod_Id = int.Parse(txtBxCADVIT_IDPROD .Text);            
            vit.Cadastrar_Vitrine();
            MessageBox.Show(vit.mensagem);
        }

        private void buttonALTERVIT_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBxALTVITID .Text);
            CRUD_Vitrine vit = new CRUD_Vitrine();
            vit.Id = id;
            vit.Prod_Id = int.Parse(textBoxALTVIT_IDPROD.Text);           
            vit.Alterar_Vitrine(vit);
            MessageBox.Show(vit.mensagem);
        }

        private void buttonDELVIT_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxDELVIT.Text);
            CRUD_Vitrine vit = new CRUD_Vitrine();
            vit.Id = id;
            vit.Excluir_Vitrine(id);
            MessageBox.Show(vit.mensagem);
        }

        private void buttonVERVIT_Click(object sender, EventArgs e)
        {
            listViewVIT.Items.Clear();
            CRUD_Vitrine vitr = new CRUD_Vitrine();
            // Chama a função para obter a lista de departamentos.
            List<CRUD_Vitrine> vitrines = vitr.Ver_Vitrine();

            // Itera sobre os departamentos retornados.
            foreach (CRUD_Vitrine vit in vitrines)
            {
                // Cria um novo ListViewItem.
                ListViewItem item = new ListViewItem(vit.Id.ToString());

                // Adiciona as subcolunas.
                item.SubItems.Add(vit.Prod_Id.ToString());
                item.SubItems.Add(vit.Nome);
                // Adiciona o item ao ListView.
                listViewVIT.Items.Add(item);
            }
        }
    }
    
}

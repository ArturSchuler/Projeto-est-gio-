namespace Loja_Guinevere
{
    public partial class FormDEP : Form
    {
        public FormDEP()
        {
            InitializeComponent();
            listvwVERDEP.View = View.Details;

            // Adiciona as colunas.
            listvwVERDEP.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listvwVERDEP.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            
        }

        private void label2_Click(object sender, EventArgs e){}

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CRUD_Dep dep = new CRUD_Dep();
            dep.Nome = txbNome.Text;
            dep.Cadastrar_dep();
            MessageBox.Show(dep.mensagem);
        }

        private void lvwListaDEP(object sender, EventArgs e){}

        private void btnALTERAR_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbxIDNEWNAME.Text);
            CRUD_Dep dep = new CRUD_Dep();
            dep.Id = id;
            dep.Nome = txtbxNEWNAME.Text;
            dep.Alterar_dep(dep);
            MessageBox.Show(dep.mensagem);
        }

        private void btnEXCLUIR_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbxEXCLUIR_ID.Text);
            CRUD_Dep dep = new CRUD_Dep();
            dep.Id = id;
            dep.Excluir_dep(id);
            MessageBox.Show(dep.mensagem);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // Limpa o ListView para evitar duplicatas.
            listvwVERDEP.Items.Clear();
            CRUD_Dep dpt = new CRUD_Dep();
            // Chama a função para obter a lista de departamentos.
            List<CRUD_Dep> departamentos = dpt.Ver_dep();

            // Itera sobre os departamentos retornados.
            foreach (CRUD_Dep dep in departamentos)
            {
                // Cria um novo ListViewItem.
                ListViewItem item = new ListViewItem(dep.Id.ToString());

                // Adiciona as subcolunas.
                item.SubItems.Add(dep.Nome);
                item.SubItems.Add(dep.Id.ToString());

                // Adiciona o item ao ListView.
                listvwVERDEP.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
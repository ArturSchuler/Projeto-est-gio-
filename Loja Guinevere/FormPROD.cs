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
    public partial class FormPROD : Form
    {
        public FormPROD()
        {
            InitializeComponent();
            listViewPROD.View = View.Details;

            // Adiciona as colunas.
            listViewPROD.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listViewPROD.Columns.Add("Id da Seção", -2, HorizontalAlignment.Left);
            listViewPROD.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listViewPROD.Columns.Add("Valor", -2, HorizontalAlignment.Left);
            listViewPROD.Columns.Add("Marca", -2, HorizontalAlignment.Left);
            listViewPROD.Columns.Add("Resumo", -2, HorizontalAlignment.Left);
            listViewPROD.Columns.Add("Detalhe", -2, HorizontalAlignment.Left);
            listViewPROD.Columns.Add("Serviço?", -2, HorizontalAlignment.Left);
            listViewPROD.Columns.Add("Preço original", -2, HorizontalAlignment.Left);
            listViewPROD.Columns.Add("Foto", -2, HorizontalAlignment.Left);
        }

        private void FormPROD_Load(object sender, EventArgs e){}

        private void btnCADASTRA_PROD_Click(object sender, EventArgs e)
        {
            CRUD_Produto prod = new CRUD_Produto();
            prod.SecId = int.Parse(txtBxCAD_SecID.Text);
            prod.Nome = txtBxCAD_nomeProd.Text;
            prod.Valor = float.Parse(txtBxCAD_valorProd.Text);
            prod.Marca = txtBxCAD_marcaProd.Text;
            prod.Resumo = txtBxCAD_resumoProd.Text;
            prod.Detalhe = txtBxCAD_detalheProd.Text;
            prod.Servico = checkBoxCAD_servico.Checked;
            prod.Valor_original = float.Parse(txtBxCAD_valorOriginal.Text);

            // Converta a imagem em um array de bytes para que possa ser armazenada no banco de dados
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    prod.Foto = ms.ToArray();
                }
            }

            prod.Cadastrar_Produto();
            foreach (var txtBox in new[] { txtBxCAD_SecID, txtBxCAD_nomeProd, txtBxCAD_valorProd, txtBxCAD_marcaProd, txtBxCAD_resumoProd, txtBxCAD_detalheProd, txtBxCAD_valorOriginal })
            {
                txtBox.Text = "";
            }

            checkBoxCAD_servico.Checked = false;
            // Limpe a imagem do PictureBox
            pictureBox1.Image = null;
            MessageBox.Show(prod.mensagem);
        }

        private void checkBoxCAD_servico_CheckedChanged(object sender, EventArgs e){}

        private void btnALTERA_PRO_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBxALTER_IDPROD.Text);
            CRUD_Produto prod = new CRUD_Produto();
            prod.Id = id;
            prod.SecId = int.Parse(txtBxALTER_IDSEC_PROD.Text);
            prod.Nome = txtBxALTER_nomeProd.Text;
            prod.Valor = float.Parse(txtBxALTER_valorProd.Text);
            prod.Marca = txtBxALTER_marcaProd.Text;
            prod.Resumo = txtBxALTER_resumoProd.Text;
            prod.Detalhe = txtBxALTER_detalheProd.Text;
            prod.Servico = checkBoxALTER_servico.Checked;
            prod.Valor_original = float.Parse(txtBxALTER_valorOriginal.Text);
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    prod.Foto = ms.ToArray();
                }
            }

            
            // Limpe a imagem do PictureBox
            pictureBox1.Image = null;
            prod.Alterar_Produto(prod);
            foreach (var txtBox in new[] { txtBxALTER_IDPROD, txtBxALTER_IDSEC_PROD, txtBxALTER_nomeProd, txtBxALTER_valorProd, txtBxALTER_marcaProd, txtBxALTER_resumoProd, txtBxALTER_detalheProd, txtBxALTER_valorOriginal })
            {
                txtBox.Text = "";
            }

            checkBoxALTER_servico.Checked = false;
            MessageBox.Show(prod.mensagem);
            
        }

        private void btnDELETA_PROD_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBxDEL_idProd.Text);
            CRUD_Produto prod = new CRUD_Produto();
            prod.Id = id;
            prod.Excluir_Produto(id);
            txtBxDEL_idProd.Clear();
            MessageBox.Show(prod.mensagem);
        }

        private void btnVER_PROD_Click(object sender, EventArgs e)
        {
            // Limpa o ListView para evitar duplicatas.
            listViewPROD.Items.Clear();
            CRUD_Produto produt = new CRUD_Produto();
            // Chama a função para obter a lista de departamentos.
            List<Produto> produtos = produt.Ver_Produto();

            // Itera sobre os departamentos retornados.
            foreach (Produto prod in produtos)
            {
                // Cria um novo ListViewItem.
                ListViewItem item = new ListViewItem(prod.Id.ToString());

                // Adiciona as subcolunas.
                item.SubItems.Add(prod.SecId.ToString());
                item.SubItems.Add(prod.Nome);
                item.SubItems.Add(prod.Valor.ToString());
                item.SubItems.Add(prod.Marca);
                item.SubItems.Add(prod.Resumo);
                item.SubItems.Add(prod.Detalhe);
                item.SubItems.Add(prod.Servico.ToString());
                item.SubItems.Add(prod.Valor_original.ToString());
                item.SubItems.Add(prod.Foto != null && prod.Foto.Length > 0 ? "Sim" : "Não");               
                // Adiciona o item ao ListView.
                listViewPROD.Items.Add(item);
            }
        }

        private void listViewPROD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Produto prod = new Produto();
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        prod.Foto = ms.ToArray();
                    }
                }
            }
        }

        private void btnCADFOTO_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png"; // filtra apenas arquivos de imagem

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Exibe a imagem escolhida no PictureBox
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnALTERFOTO_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png"; // filtra apenas arquivos de imagem

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Exibe a imagem escolhida no PictureBox
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}

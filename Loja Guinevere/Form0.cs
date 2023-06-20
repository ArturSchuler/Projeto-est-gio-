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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDEP obj1 = new FormDEP();
            //obj1.MdiParent = this;  
            obj1.WindowState = FormWindowState.Maximized;
            obj1.Show();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSET obj2 = new FormSET();
            //obj2.MdiParent = this;
            obj2.WindowState = FormWindowState.Maximized;
            obj2.Show();
        }

        private void seçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSEC obj3 = new FormSEC();
            //obj2.MdiParent = this;
            obj3.WindowState = FormWindowState.Maximized;
            obj3.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPROD obj4 = new FormPROD();
            //obj2.MdiParent = this;
            obj4.WindowState = FormWindowState.Maximized;
            obj4.Show();
        }

        

        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormVITRINE obj10 = new FormVITRINE();
            //obj2.MdiParent = this;
            obj10.WindowState = FormWindowState.Maximized;
            obj10.Show();*/
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormVITRINE obj10 = new FormVITRINE();
            //obj2.MdiParent = this;
            obj10.WindowState = FormWindowState.Maximized;
            obj10.Show();*/
        }
        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormVITRINE obj10 = new FormVITRINE();
            //obj2.MdiParent = this;
            obj10.WindowState = FormWindowState.Maximized;
            obj10.Show();*/
        }
        private void promoçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPROMO obj8 = new FormPROMO();
            //obj2.MdiParent = this;
            obj8.WindowState = FormWindowState.Maximized;
            obj8.Show();
        }

        private void descontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormVITRINE obj9 = new FormVITRINE();
            //obj2.MdiParent = this;
            obj9.WindowState = FormWindowState.Maximized;
            obj9.Show();*/
        }

        

        
        private void vitrineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVITRIcs obj10 = new FormVITRIcs();
            //obj2.MdiParent = this;
            obj10.WindowState = FormWindowState.Maximized;
            obj10.Show();
        }

        
    }   


}

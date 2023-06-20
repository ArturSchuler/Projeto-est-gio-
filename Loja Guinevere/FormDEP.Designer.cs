namespace Loja_Guinevere
{
    partial class FormDEP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.listvwVERDEP = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID_NEWNAME = new System.Windows.Forms.Label();
            this.txtbxNEWNAME = new System.Windows.Forms.TextBox();
            this.txtbxIDNEWNAME = new System.Windows.Forms.TextBox();
            this.btnALTERAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxEXCLUIR_ID = new System.Windows.Forms.TextBox();
            this.btnEXCLUIR = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(115, 86);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(125, 27);
            this.txbNome.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(317, 86);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 29);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // listvwVERDEP
            // 
            this.listvwVERDEP.Location = new System.Drawing.Point(573, 40);
            this.listvwVERDEP.Name = "listvwVERDEP";
            this.listvwVERDEP.Size = new System.Drawing.Size(506, 328);
            this.listvwVERDEP.TabIndex = 6;
            this.listvwVERDEP.UseCompatibleStateImageBehavior = false;
            this.listvwVERDEP.SelectedIndexChanged += new System.EventHandler(this.lvwListaDEP);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Novo Nome";
            // 
            // txbID_NEWNAME
            // 
            this.txbID_NEWNAME.AutoSize = true;
            this.txbID_NEWNAME.Location = new System.Drawing.Point(38, 174);
            this.txbID_NEWNAME.Name = "txbID_NEWNAME";
            this.txbID_NEWNAME.Size = new System.Drawing.Size(24, 20);
            this.txbID_NEWNAME.TabIndex = 8;
            this.txbID_NEWNAME.Text = "ID";
            // 
            // txtbxNEWNAME
            // 
            this.txtbxNEWNAME.Location = new System.Drawing.Point(115, 215);
            this.txtbxNEWNAME.Name = "txtbxNEWNAME";
            this.txtbxNEWNAME.Size = new System.Drawing.Size(125, 27);
            this.txtbxNEWNAME.TabIndex = 9;
            // 
            // txtbxIDNEWNAME
            // 
            this.txtbxIDNEWNAME.Location = new System.Drawing.Point(115, 167);
            this.txtbxIDNEWNAME.Name = "txtbxIDNEWNAME";
            this.txtbxIDNEWNAME.Size = new System.Drawing.Size(125, 27);
            this.txtbxIDNEWNAME.TabIndex = 10;
            // 
            // btnALTERAR
            // 
            this.btnALTERAR.Location = new System.Drawing.Point(317, 193);
            this.btnALTERAR.Name = "btnALTERAR";
            this.btnALTERAR.Size = new System.Drawing.Size(94, 29);
            this.btnALTERAR.TabIndex = 11;
            this.btnALTERAR.Text = "Alterar";
            this.btnALTERAR.UseVisualStyleBackColor = true;
            this.btnALTERAR.Click += new System.EventHandler(this.btnALTERAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID";
            // 
            // txtbxEXCLUIR_ID
            // 
            this.txtbxEXCLUIR_ID.Location = new System.Drawing.Point(115, 312);
            this.txtbxEXCLUIR_ID.Name = "txtbxEXCLUIR_ID";
            this.txtbxEXCLUIR_ID.Size = new System.Drawing.Size(125, 27);
            this.txtbxEXCLUIR_ID.TabIndex = 13;
            // 
            // btnEXCLUIR
            // 
            this.btnEXCLUIR.Location = new System.Drawing.Point(317, 312);
            this.btnEXCLUIR.Name = "btnEXCLUIR";
            this.btnEXCLUIR.Size = new System.Drawing.Size(94, 29);
            this.btnEXCLUIR.TabIndex = 14;
            this.btnEXCLUIR.Text = "Excluir";
            this.btnEXCLUIR.UseVisualStyleBackColor = true;
            this.btnEXCLUIR.Click += new System.EventHandler(this.btnEXCLUIR_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(774, 388);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(94, 29);
            this.btnView.TabIndex = 15;
            this.btnView.Text = "Ver";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // FormDEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 450);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnEXCLUIR);
            this.Controls.Add(this.txtbxEXCLUIR_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnALTERAR);
            this.Controls.Add(this.txtbxIDNEWNAME);
            this.Controls.Add(this.txtbxNEWNAME);
            this.Controls.Add(this.txbID_NEWNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listvwVERDEP);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Name = "FormDEP";
            this.Text = "Departamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbNome;
        private Button btnCadastrar;
        private ListView listvwVERDEP;
        private Label label2;
        private Label txbID_NEWNAME;
        private TextBox txtbxNEWNAME;
        private TextBox txtbxIDNEWNAME;
        private Button btnALTERAR;
        private Label label3;
        private TextBox txtbxEXCLUIR_ID;
        private Button btnEXCLUIR;
        private Button btnView;
    }
}
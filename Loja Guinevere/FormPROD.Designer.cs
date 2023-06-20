namespace Loja_Guinevere
{
    partial class FormPROD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxCAD_servico = new System.Windows.Forms.CheckBox();
            this.btnCADASTRA_PROD = new System.Windows.Forms.Button();
            this.txtBxCAD_SecID = new System.Windows.Forms.TextBox();
            this.txtBxCAD_nomeProd = new System.Windows.Forms.TextBox();
            this.txtBxCAD_valorProd = new System.Windows.Forms.TextBox();
            this.txtBxCAD_marcaProd = new System.Windows.Forms.TextBox();
            this.txtBxCAD_resumoProd = new System.Windows.Forms.TextBox();
            this.txtBxCAD_detalheProd = new System.Windows.Forms.TextBox();
            this.txtBxCAD_valorOriginal = new System.Windows.Forms.TextBox();
            this.txtBxALTER_valorOriginal = new System.Windows.Forms.TextBox();
            this.txtBxALTER_detalheProd = new System.Windows.Forms.TextBox();
            this.txtBxALTER_resumoProd = new System.Windows.Forms.TextBox();
            this.txtBxALTER_marcaProd = new System.Windows.Forms.TextBox();
            this.txtBxALTER_valorProd = new System.Windows.Forms.TextBox();
            this.txtBxALTER_nomeProd = new System.Windows.Forms.TextBox();
            this.txtBxALTER_IDSEC_PROD = new System.Windows.Forms.TextBox();
            this.btnALTERA_PRO = new System.Windows.Forms.Button();
            this.checkBoxALTER_servico = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBxALTER_IDPROD = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBxDEL_idProd = new System.Windows.Forms.TextBox();
            this.btnDELETA_PROD = new System.Windows.Forms.Button();
            this.listViewPROD = new System.Windows.Forms.ListView();
            this.btnVER_PROD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCADFOTO = new System.Windows.Forms.Button();
            this.btnALTERFOTO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id da Seção";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca do Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resumo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Detalhe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "É um Serviço?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Preço Original";
            // 
            // checkBoxCAD_servico
            // 
            this.checkBoxCAD_servico.AutoSize = true;
            this.checkBoxCAD_servico.Location = new System.Drawing.Point(212, 278);
            this.checkBoxCAD_servico.Name = "checkBoxCAD_servico";
            this.checkBoxCAD_servico.Size = new System.Drawing.Size(56, 24);
            this.checkBoxCAD_servico.TabIndex = 8;
            this.checkBoxCAD_servico.Text = "Sim";
            this.checkBoxCAD_servico.UseVisualStyleBackColor = true;
            this.checkBoxCAD_servico.CheckedChanged += new System.EventHandler(this.checkBoxCAD_servico_CheckedChanged);
            // 
            // btnCADASTRA_PROD
            // 
            this.btnCADASTRA_PROD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCADASTRA_PROD.Location = new System.Drawing.Point(359, 307);
            this.btnCADASTRA_PROD.Name = "btnCADASTRA_PROD";
            this.btnCADASTRA_PROD.Size = new System.Drawing.Size(94, 29);
            this.btnCADASTRA_PROD.TabIndex = 9;
            this.btnCADASTRA_PROD.Text = "Cadastrar";
            this.btnCADASTRA_PROD.UseVisualStyleBackColor = false;
            this.btnCADASTRA_PROD.Click += new System.EventHandler(this.btnCADASTRA_PROD_Click);
            // 
            // txtBxCAD_SecID
            // 
            this.txtBxCAD_SecID.Location = new System.Drawing.Point(180, 32);
            this.txtBxCAD_SecID.Name = "txtBxCAD_SecID";
            this.txtBxCAD_SecID.Size = new System.Drawing.Size(125, 27);
            this.txtBxCAD_SecID.TabIndex = 10;
            // 
            // txtBxCAD_nomeProd
            // 
            this.txtBxCAD_nomeProd.Location = new System.Drawing.Point(180, 74);
            this.txtBxCAD_nomeProd.Name = "txtBxCAD_nomeProd";
            this.txtBxCAD_nomeProd.Size = new System.Drawing.Size(125, 27);
            this.txtBxCAD_nomeProd.TabIndex = 11;
            // 
            // txtBxCAD_valorProd
            // 
            this.txtBxCAD_valorProd.Location = new System.Drawing.Point(180, 118);
            this.txtBxCAD_valorProd.Name = "txtBxCAD_valorProd";
            this.txtBxCAD_valorProd.Size = new System.Drawing.Size(125, 27);
            this.txtBxCAD_valorProd.TabIndex = 12;
            // 
            // txtBxCAD_marcaProd
            // 
            this.txtBxCAD_marcaProd.Location = new System.Drawing.Point(180, 157);
            this.txtBxCAD_marcaProd.Name = "txtBxCAD_marcaProd";
            this.txtBxCAD_marcaProd.Size = new System.Drawing.Size(125, 27);
            this.txtBxCAD_marcaProd.TabIndex = 13;
            // 
            // txtBxCAD_resumoProd
            // 
            this.txtBxCAD_resumoProd.Location = new System.Drawing.Point(180, 200);
            this.txtBxCAD_resumoProd.Name = "txtBxCAD_resumoProd";
            this.txtBxCAD_resumoProd.Size = new System.Drawing.Size(300, 27);
            this.txtBxCAD_resumoProd.TabIndex = 14;
            // 
            // txtBxCAD_detalheProd
            // 
            this.txtBxCAD_detalheProd.Location = new System.Drawing.Point(180, 245);
            this.txtBxCAD_detalheProd.Name = "txtBxCAD_detalheProd";
            this.txtBxCAD_detalheProd.Size = new System.Drawing.Size(300, 27);
            this.txtBxCAD_detalheProd.TabIndex = 15;
            // 
            // txtBxCAD_valorOriginal
            // 
            this.txtBxCAD_valorOriginal.Location = new System.Drawing.Point(180, 309);
            this.txtBxCAD_valorOriginal.Name = "txtBxCAD_valorOriginal";
            this.txtBxCAD_valorOriginal.Size = new System.Drawing.Size(125, 27);
            this.txtBxCAD_valorOriginal.TabIndex = 16;
            // 
            // txtBxALTER_valorOriginal
            // 
            this.txtBxALTER_valorOriginal.Location = new System.Drawing.Point(187, 785);
            this.txtBxALTER_valorOriginal.Name = "txtBxALTER_valorOriginal";
            this.txtBxALTER_valorOriginal.Size = new System.Drawing.Size(125, 27);
            this.txtBxALTER_valorOriginal.TabIndex = 33;
            // 
            // txtBxALTER_detalheProd
            // 
            this.txtBxALTER_detalheProd.Location = new System.Drawing.Point(187, 721);
            this.txtBxALTER_detalheProd.Name = "txtBxALTER_detalheProd";
            this.txtBxALTER_detalheProd.Size = new System.Drawing.Size(293, 27);
            this.txtBxALTER_detalheProd.TabIndex = 32;
            // 
            // txtBxALTER_resumoProd
            // 
            this.txtBxALTER_resumoProd.Location = new System.Drawing.Point(187, 676);
            this.txtBxALTER_resumoProd.Name = "txtBxALTER_resumoProd";
            this.txtBxALTER_resumoProd.Size = new System.Drawing.Size(293, 27);
            this.txtBxALTER_resumoProd.TabIndex = 31;
            // 
            // txtBxALTER_marcaProd
            // 
            this.txtBxALTER_marcaProd.Location = new System.Drawing.Point(187, 633);
            this.txtBxALTER_marcaProd.Name = "txtBxALTER_marcaProd";
            this.txtBxALTER_marcaProd.Size = new System.Drawing.Size(125, 27);
            this.txtBxALTER_marcaProd.TabIndex = 30;
            // 
            // txtBxALTER_valorProd
            // 
            this.txtBxALTER_valorProd.Location = new System.Drawing.Point(187, 594);
            this.txtBxALTER_valorProd.Name = "txtBxALTER_valorProd";
            this.txtBxALTER_valorProd.Size = new System.Drawing.Size(125, 27);
            this.txtBxALTER_valorProd.TabIndex = 29;
            // 
            // txtBxALTER_nomeProd
            // 
            this.txtBxALTER_nomeProd.Location = new System.Drawing.Point(187, 550);
            this.txtBxALTER_nomeProd.Name = "txtBxALTER_nomeProd";
            this.txtBxALTER_nomeProd.Size = new System.Drawing.Size(125, 27);
            this.txtBxALTER_nomeProd.TabIndex = 28;
            // 
            // txtBxALTER_IDSEC_PROD
            // 
            this.txtBxALTER_IDSEC_PROD.Location = new System.Drawing.Point(187, 506);
            this.txtBxALTER_IDSEC_PROD.Name = "txtBxALTER_IDSEC_PROD";
            this.txtBxALTER_IDSEC_PROD.Size = new System.Drawing.Size(125, 27);
            this.txtBxALTER_IDSEC_PROD.TabIndex = 27;
            // 
            // btnALTERA_PRO
            // 
            this.btnALTERA_PRO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnALTERA_PRO.Location = new System.Drawing.Point(359, 785);
            this.btnALTERA_PRO.Name = "btnALTERA_PRO";
            this.btnALTERA_PRO.Size = new System.Drawing.Size(94, 29);
            this.btnALTERA_PRO.TabIndex = 26;
            this.btnALTERA_PRO.Text = "Alterar";
            this.btnALTERA_PRO.UseVisualStyleBackColor = false;
            this.btnALTERA_PRO.Click += new System.EventHandler(this.btnALTERA_PRO_Click);
            // 
            // checkBoxALTER_servico
            // 
            this.checkBoxALTER_servico.AutoSize = true;
            this.checkBoxALTER_servico.Location = new System.Drawing.Point(219, 754);
            this.checkBoxALTER_servico.Name = "checkBoxALTER_servico";
            this.checkBoxALTER_servico.Size = new System.Drawing.Size(56, 24);
            this.checkBoxALTER_servico.TabIndex = 25;
            this.checkBoxALTER_servico.Text = "Sim";
            this.checkBoxALTER_servico.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 792);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Preço Original";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 755);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "É um Serviço?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 721);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Detalhe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 676);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Resumo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 635);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Marca do Produto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 596);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Valor do Produto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 550);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Nome do Produto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 513);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Id da Seção";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 471);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Id do Produto";
            // 
            // txtBxALTER_IDPROD
            // 
            this.txtBxALTER_IDPROD.Location = new System.Drawing.Point(187, 464);
            this.txtBxALTER_IDPROD.Name = "txtBxALTER_IDPROD";
            this.txtBxALTER_IDPROD.Size = new System.Drawing.Size(125, 27);
            this.txtBxALTER_IDPROD.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 898);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 20);
            this.label18.TabIndex = 36;
            this.label18.Text = "Id do Produto";
            // 
            // txtBxDEL_idProd
            // 
            this.txtBxDEL_idProd.Location = new System.Drawing.Point(168, 895);
            this.txtBxDEL_idProd.Name = "txtBxDEL_idProd";
            this.txtBxDEL_idProd.Size = new System.Drawing.Size(125, 27);
            this.txtBxDEL_idProd.TabIndex = 37;
            // 
            // btnDELETA_PROD
            // 
            this.btnDELETA_PROD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDELETA_PROD.Location = new System.Drawing.Point(340, 893);
            this.btnDELETA_PROD.Name = "btnDELETA_PROD";
            this.btnDELETA_PROD.Size = new System.Drawing.Size(94, 29);
            this.btnDELETA_PROD.TabIndex = 38;
            this.btnDELETA_PROD.Text = "Excluir";
            this.btnDELETA_PROD.UseVisualStyleBackColor = false;
            this.btnDELETA_PROD.Click += new System.EventHandler(this.btnDELETA_PROD_Click);
            // 
            // listViewPROD
            // 
            this.listViewPROD.Location = new System.Drawing.Point(539, 35);
            this.listViewPROD.Name = "listViewPROD";
            this.listViewPROD.Size = new System.Drawing.Size(1059, 761);
            this.listViewPROD.TabIndex = 39;
            this.listViewPROD.UseCompatibleStateImageBehavior = false;
            this.listViewPROD.SelectedIndexChanged += new System.EventHandler(this.listViewPROD_SelectedIndexChanged);
            // 
            // btnVER_PROD
            // 
            this.btnVER_PROD.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVER_PROD.Location = new System.Drawing.Point(995, 869);
            this.btnVER_PROD.Name = "btnVER_PROD";
            this.btnVER_PROD.Size = new System.Drawing.Size(156, 55);
            this.btnVER_PROD.TabIndex = 40;
            this.btnVER_PROD.Text = "Ver";
            this.btnVER_PROD.UseVisualStyleBackColor = false;
            this.btnVER_PROD.Click += new System.EventHandler(this.btnVER_PROD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1613, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 253);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnCADFOTO
            // 
            this.btnCADFOTO.Location = new System.Drawing.Point(331, 30);
            this.btnCADFOTO.Name = "btnCADFOTO";
            this.btnCADFOTO.Size = new System.Drawing.Size(149, 149);
            this.btnCADFOTO.TabIndex = 42;
            this.btnCADFOTO.Text = "Foto";
            this.btnCADFOTO.UseVisualStyleBackColor = true;
            this.btnCADFOTO.Click += new System.EventHandler(this.btnCADFOTO_Click);
            // 
            // btnALTERFOTO
            // 
            this.btnALTERFOTO.Location = new System.Drawing.Point(331, 464);
            this.btnALTERFOTO.Name = "btnALTERFOTO";
            this.btnALTERFOTO.Size = new System.Drawing.Size(149, 157);
            this.btnALTERFOTO.TabIndex = 43;
            this.btnALTERFOTO.Text = "Alterar Foto";
            this.btnALTERFOTO.UseVisualStyleBackColor = true;
            this.btnALTERFOTO.Click += new System.EventHandler(this.btnALTERFOTO_Click);
            // 
            // FormPROD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1897, 1055);
            this.Controls.Add(this.btnALTERFOTO);
            this.Controls.Add(this.btnCADFOTO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVER_PROD);
            this.Controls.Add(this.listViewPROD);
            this.Controls.Add(this.btnDELETA_PROD);
            this.Controls.Add(this.txtBxDEL_idProd);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtBxALTER_IDPROD);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtBxALTER_valorOriginal);
            this.Controls.Add(this.txtBxALTER_detalheProd);
            this.Controls.Add(this.txtBxALTER_resumoProd);
            this.Controls.Add(this.txtBxALTER_marcaProd);
            this.Controls.Add(this.txtBxALTER_valorProd);
            this.Controls.Add(this.txtBxALTER_nomeProd);
            this.Controls.Add(this.txtBxALTER_IDSEC_PROD);
            this.Controls.Add(this.btnALTERA_PRO);
            this.Controls.Add(this.checkBoxALTER_servico);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBxCAD_valorOriginal);
            this.Controls.Add(this.txtBxCAD_detalheProd);
            this.Controls.Add(this.txtBxCAD_resumoProd);
            this.Controls.Add(this.txtBxCAD_marcaProd);
            this.Controls.Add(this.txtBxCAD_valorProd);
            this.Controls.Add(this.txtBxCAD_nomeProd);
            this.Controls.Add(this.txtBxCAD_SecID);
            this.Controls.Add(this.btnCADASTRA_PROD);
            this.Controls.Add(this.checkBoxCAD_servico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPROD";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FormPROD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox checkBoxCAD_servico;
        private Button btnCADASTRA_PROD;
        private TextBox txtBxCAD_SecID;
        private TextBox txtBxCAD_nomeProd;
        private TextBox txtBxCAD_valorProd;
        private TextBox txtBxCAD_marcaProd;
        private TextBox txtBxCAD_resumoProd;
        private TextBox txtBxCAD_detalheProd;
        private TextBox txtBxCAD_valorOriginal;
        private TextBox txtBxALTER_valorOriginal;
        private TextBox txtBxALTER_detalheProd;
        private TextBox txtBxALTER_resumoProd;
        private TextBox txtBxALTER_marcaProd;
        private TextBox txtBxALTER_valorProd;
        private TextBox txtBxALTER_nomeProd;
        private TextBox txtBxALTER_IDSEC_PROD;
        private Button btnALTERA_PRO;
        private CheckBox checkBoxALTER_servico;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtBxALTER_IDPROD;
        private Label label18;
        private TextBox txtBxDEL_idProd;
        private Button btnDELETA_PROD;
        private ListView listViewPROD;
        private Button btnVER_PROD;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnCADFOTO;
        private Button btnALTERFOTO;
    }
}
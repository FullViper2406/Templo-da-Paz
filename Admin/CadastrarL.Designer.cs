﻿
namespace WindowsFormsApp1
{
    partial class CadastrarL
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
            this.cStatus = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.mCRM = new System.Windows.Forms.MaskedTextBox();
            this.CRMLegista = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lSenha = new System.Windows.Forms.LinkLabel();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.textRG = new System.Windows.Forms.MaskedTextBox();
            this.mDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.cSexo = new System.Windows.Forms.ComboBox();
            this.cEstadoCivil = new System.Windows.Forms.ComboBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cContato = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mCelular = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cStatus
            // 
            this.cStatus.FormattingEnabled = true;
            this.cStatus.Location = new System.Drawing.Point(542, 269);
            this.cStatus.Name = "cStatus";
            this.cStatus.Size = new System.Drawing.Size(121, 21);
            this.cStatus.TabIndex = 85;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(467, 269);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 84;
            this.Status.Text = "Status";
            // 
            // mCRM
            // 
            this.mCRM.Location = new System.Drawing.Point(310, 277);
            this.mCRM.Mask = "0000000";
            this.mCRM.Name = "mCRM";
            this.mCRM.Size = new System.Drawing.Size(100, 20);
            this.mCRM.TabIndex = 83;
            this.mCRM.ValidatingType = typeof(System.DateTime);
            this.mCRM.Click += new System.EventHandler(this.mCRM_Click);
            // 
            // CRMLegista
            // 
            this.CRMLegista.AutoSize = true;
            this.CRMLegista.Location = new System.Drawing.Point(196, 277);
            this.CRMLegista.Name = "CRMLegista";
            this.CRMLegista.Size = new System.Drawing.Size(68, 13);
            this.CRMLegista.TabIndex = 82;
            this.CRMLegista.Text = "CRM Legista";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "RG";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "CPF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 78;
            this.label11.Text = "Nome";
            // 
            // lSenha
            // 
            this.lSenha.ActiveLinkColor = System.Drawing.Color.Black;
            this.lSenha.AutoSize = true;
            this.lSenha.LinkColor = System.Drawing.Color.Black;
            this.lSenha.Location = new System.Drawing.Point(658, 230);
            this.lSenha.Name = "lSenha";
            this.lSenha.Size = new System.Drawing.Size(73, 13);
            this.lSenha.TabIndex = 77;
            this.lSenha.TabStop = true;
            this.lSenha.Text = "MostrarSenha";
            this.lSenha.VisitedLinkColor = System.Drawing.Color.Black;
            this.lSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSenha_LinkClicked);
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(103, 146);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(100, 20);
            this.textCpf.TabIndex = 76;
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(116, 186);
            this.textRG.Mask = "00.000.000-0";
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(100, 20);
            this.textRG.TabIndex = 75;
            this.textRG.Click += new System.EventHandler(this.textRG_Click);
            // 
            // mDataNascimento
            // 
            this.mDataNascimento.Location = new System.Drawing.Point(310, 153);
            this.mDataNascimento.Mask = "00/00/0000";
            this.mDataNascimento.Name = "mDataNascimento";
            this.mDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mDataNascimento.TabIndex = 73;
            this.mDataNascimento.ValidatingType = typeof(System.DateTime);
            this.mDataNascimento.Click += new System.EventHandler(this.mDataNascimento_Click);
            // 
            // cSexo
            // 
            this.cSexo.FormattingEnabled = true;
            this.cSexo.Location = new System.Drawing.Point(583, 194);
            this.cSexo.Name = "cSexo";
            this.cSexo.Size = new System.Drawing.Size(121, 21);
            this.cSexo.TabIndex = 72;
            // 
            // cEstadoCivil
            // 
            this.cEstadoCivil.FormattingEnabled = true;
            this.cEstadoCivil.Location = new System.Drawing.Point(583, 160);
            this.cEstadoCivil.Name = "cEstadoCivil";
            this.cEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cEstadoCivil.TabIndex = 71;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(301, 116);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(100, 20);
            this.textEndereco.TabIndex = 70;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(542, 230);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(100, 20);
            this.textSenha.TabIndex = 69;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(116, 115);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "DataNascimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "EstadoCivil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Sexo";
            // 
            // bCadastrar
            // 
            this.bCadastrar.Location = new System.Drawing.Point(270, 312);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bCadastrar.TabIndex = 60;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(103, 292);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 91;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cContato
            // 
            this.cContato.FormattingEnabled = true;
            this.cContato.Location = new System.Drawing.Point(297, 185);
            this.cContato.Name = "cContato";
            this.cContato.Size = new System.Drawing.Size(121, 21);
            this.cContato.TabIndex = 93;
            this.cContato.SelectedIndexChanged += new System.EventHandler(this.cContato_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Contato";
            // 
            // mCelular
            // 
            this.mCelular.Location = new System.Drawing.Point(335, 208);
            this.mCelular.Name = "mCelular";
            this.mCelular.Size = new System.Drawing.Size(100, 20);
            this.mCelular.TabIndex = 107;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(251, 249);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(49, 13);
            this.Telefone.TabIndex = 106;
            this.Telefone.Text = "Telefone";
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Location = new System.Drawing.Point(261, 215);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(39, 13);
            this.Celular.TabIndex = 105;
            this.Celular.Text = "Celular";
            // 
            // CadastrarL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mCelular);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.cContato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.cStatus);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.mCRM);
            this.Controls.Add(this.CRMLegista);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lSenha);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.mDataNascimento);
            this.Controls.Add(this.cSexo);
            this.Controls.Add(this.cEstadoCivil);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bCadastrar);
            this.Name = "CadastrarL";
            this.Text = "CadastrarL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cStatus;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.MaskedTextBox mCRM;
        private System.Windows.Forms.Label CRMLegista;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel lSenha;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.MaskedTextBox textRG;
        private System.Windows.Forms.MaskedTextBox mDataNascimento;
        private System.Windows.Forms.ComboBox cSexo;
        private System.Windows.Forms.ComboBox cEstadoCivil;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cContato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mCelular;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label Celular;
    }
}
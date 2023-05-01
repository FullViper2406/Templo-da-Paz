﻿
namespace WindowsFormsApp1
{
    partial class DadosCadaverLM
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
            this.Quantidade = new System.Windows.Forms.Label();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.textMaterial = new System.Windows.Forms.TextBox();
            this.cRetirada = new System.Windows.Forms.ComboBox();
            this.textLaudo = new System.Windows.Forms.RichTextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textGaveta = new System.Windows.Forms.TextBox();
            this.mHorarioChegada = new System.Windows.Forms.MaskedTextBox();
            this.mDataRetirada = new System.Windows.Forms.MaskedTextBox();
            this.mDataChegada = new System.Windows.Forms.MaskedTextBox();
            this.Gaveta = new System.Windows.Forms.Label();
            this.Retirada = new System.Windows.Forms.Label();
            this.Datare = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.Label();
            this.DataCheg = new System.Windows.Forms.Label();
            this.Laudo = new System.Windows.Forms.Label();
            this.Material = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.bAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(298, 277);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(62, 13);
            this.Quantidade.TabIndex = 74;
            this.Quantidade.Text = "Quantidade";
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(384, 270);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textQuantidade.TabIndex = 73;
            // 
            // textMaterial
            // 
            this.textMaterial.Location = new System.Drawing.Point(340, 226);
            this.textMaterial.Name = "textMaterial";
            this.textMaterial.Size = new System.Drawing.Size(100, 20);
            this.textMaterial.TabIndex = 72;
            // 
            // cRetirada
            // 
            this.cRetirada.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.cRetirada.FormattingEnabled = true;
            this.cRetirada.Location = new System.Drawing.Point(627, 233);
            this.cRetirada.Name = "cRetirada";
            this.cRetirada.Size = new System.Drawing.Size(156, 21);
            this.cRetirada.TabIndex = 71;
            // 
            // textLaudo
            // 
            this.textLaudo.Location = new System.Drawing.Point(340, 95);
            this.textLaudo.Name = "textLaudo";
            this.textLaudo.Size = new System.Drawing.Size(100, 96);
            this.textLaudo.TabIndex = 70;
            this.textLaudo.Text = "";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(83, 98);
            this.textNome.MaximumSize = new System.Drawing.Size(100, 100);
            this.textNome.MinimumSize = new System.Drawing.Size(20, 20);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 69;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(83, 133);
            this.textID.MaximumSize = new System.Drawing.Size(100, 100);
            this.textID.MinimumSize = new System.Drawing.Size(20, 20);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 68;
            // 
            // textGaveta
            // 
            this.textGaveta.Location = new System.Drawing.Point(83, 189);
            this.textGaveta.MaximumSize = new System.Drawing.Size(100, 100);
            this.textGaveta.MinimumSize = new System.Drawing.Size(20, 20);
            this.textGaveta.Name = "textGaveta";
            this.textGaveta.Size = new System.Drawing.Size(100, 20);
            this.textGaveta.TabIndex = 67;
            // 
            // mHorarioChegada
            // 
            this.mHorarioChegada.Location = new System.Drawing.Point(647, 136);
            this.mHorarioChegada.Mask = "00:00";
            this.mHorarioChegada.Name = "mHorarioChegada";
            this.mHorarioChegada.Size = new System.Drawing.Size(100, 20);
            this.mHorarioChegada.TabIndex = 66;
            this.mHorarioChegada.ValidatingType = typeof(System.DateTime);
            // 
            // mDataRetirada
            // 
            this.mDataRetirada.Location = new System.Drawing.Point(671, 186);
            this.mDataRetirada.Mask = "00/00/0000";
            this.mDataRetirada.Name = "mDataRetirada";
            this.mDataRetirada.Size = new System.Drawing.Size(100, 20);
            this.mDataRetirada.TabIndex = 65;
            this.mDataRetirada.ValidatingType = typeof(System.DateTime);
            // 
            // mDataChegada
            // 
            this.mDataChegada.Location = new System.Drawing.Point(627, 102);
            this.mDataChegada.Mask = "00/00/0000";
            this.mDataChegada.Name = "mDataChegada";
            this.mDataChegada.Size = new System.Drawing.Size(100, 20);
            this.mDataChegada.TabIndex = 64;
            this.mDataChegada.ValidatingType = typeof(System.DateTime);
            // 
            // Gaveta
            // 
            this.Gaveta.AutoSize = true;
            this.Gaveta.Location = new System.Drawing.Point(18, 196);
            this.Gaveta.Name = "Gaveta";
            this.Gaveta.Size = new System.Drawing.Size(42, 13);
            this.Gaveta.TabIndex = 63;
            this.Gaveta.Text = "Gaveta";
            // 
            // Retirada
            // 
            this.Retirada.AutoSize = true;
            this.Retirada.Location = new System.Drawing.Point(546, 233);
            this.Retirada.Name = "Retirada";
            this.Retirada.Size = new System.Drawing.Size(47, 13);
            this.Retirada.TabIndex = 62;
            this.Retirada.Text = "Retirada";
            // 
            // Datare
            // 
            this.Datare.AutoSize = true;
            this.Datare.Location = new System.Drawing.Point(546, 189);
            this.Datare.Name = "Datare";
            this.Datare.Size = new System.Drawing.Size(68, 13);
            this.Datare.TabIndex = 61;
            this.Datare.Text = "Data retirada";
            // 
            // Horario
            // 
            this.Horario.AutoSize = true;
            this.Horario.Location = new System.Drawing.Point(517, 140);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(86, 13);
            this.Horario.TabIndex = 60;
            this.Horario.Text = "Horário chegada";
            // 
            // DataCheg
            // 
            this.DataCheg.AutoSize = true;
            this.DataCheg.Location = new System.Drawing.Point(517, 105);
            this.DataCheg.Name = "DataCheg";
            this.DataCheg.Size = new System.Drawing.Size(75, 13);
            this.DataCheg.TabIndex = 59;
            this.DataCheg.Text = "Data chegada";
            // 
            // Laudo
            // 
            this.Laudo.AutoSize = true;
            this.Laudo.Location = new System.Drawing.Point(283, 98);
            this.Laudo.Name = "Laudo";
            this.Laudo.Size = new System.Drawing.Size(37, 13);
            this.Laudo.TabIndex = 58;
            this.Laudo.Text = "Laudo";
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Location = new System.Drawing.Point(264, 228);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(44, 13);
            this.Material.TabIndex = 57;
            this.Material.Text = "Material";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(42, 133);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 56;
            this.ID.Text = "ID";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(42, 98);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 55;
            this.Nome.Text = "Nome";
            // 
            // bAlterar
            // 
            this.bAlterar.Location = new System.Drawing.Point(365, 332);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 54;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            // 
            // DadosCadaverLM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.textMaterial);
            this.Controls.Add(this.cRetirada);
            this.Controls.Add(this.textLaudo);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textGaveta);
            this.Controls.Add(this.mHorarioChegada);
            this.Controls.Add(this.mDataRetirada);
            this.Controls.Add(this.mDataChegada);
            this.Controls.Add(this.Gaveta);
            this.Controls.Add(this.Retirada);
            this.Controls.Add(this.Datare);
            this.Controls.Add(this.Horario);
            this.Controls.Add(this.DataCheg);
            this.Controls.Add(this.Laudo);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.bAlterar);
            this.Name = "DadosCadaverLM";
            this.Text = "DadosCadaverLM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.TextBox textMaterial;
        private System.Windows.Forms.ComboBox cRetirada;
        private System.Windows.Forms.RichTextBox textLaudo;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textGaveta;
        private System.Windows.Forms.MaskedTextBox mHorarioChegada;
        private System.Windows.Forms.MaskedTextBox mDataRetirada;
        private System.Windows.Forms.MaskedTextBox mDataChegada;
        private System.Windows.Forms.Label Gaveta;
        private System.Windows.Forms.Label Retirada;
        private System.Windows.Forms.Label Datare;
        private System.Windows.Forms.Label Horario;
        private System.Windows.Forms.Label DataCheg;
        private System.Windows.Forms.Label Laudo;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button bAlterar;
    }
}
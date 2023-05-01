﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DadosF : Form
    {
        public DadosF()
        {
            InitializeComponent();
            dDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void bLocalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNome.Text))
            {
                MessageBox.Show("Campo 'Nome' vazio, preencha-o!");
                return;
            }
            else if (textNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, insira apenas carecteres no campo 'Nome'.");
                return;
            }
            else
            {
                MessageBox.Show("Localizado com sucesso");
                textNome.Text = "";
            }
        }

        private void DadosF_Click(object sender, EventArgs e)
        {
            this.Hide();

            AlterarF novaTela = new AlterarF();
            novaTela.ShowDialog();
        }

        private void dDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();

            AlterarF novaTela = new AlterarF();
            novaTela.ShowDialog();
        }
    }
    }


using MusicStation_Pablo.MusicStationDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MusicStation_Pablo.MusicStationDataSet;

namespace MusicStation_Pablo
{
    public partial class UC_CrudFormasPagamentos : UserControl
    {
        public UC_CrudFormasPagamentos()
        {
            InitializeComponent();

            Formas_PagamentoTableAdapter formas = new Formas_PagamentoTableAdapter();
            var obterFormas = from linha in formas.GetData() select linha;
            foreach (var cliente in obterFormas)
            {
                cboFormaPagamento.Items.Add(cliente);
            }
            cboFormaPagamento.SelectedIndex = -1;

            atualizarLista();
        }


        private void atualizarLista()
        {
            lboFormaPagamento.ClearSelected();
            lboFormaPagamento.Items.Clear();
            Formas_PagamentoTableAdapter formasPagamentoAdapter = new Formas_PagamentoTableAdapter();
            var obterFormasPagamento = from linha in formasPagamentoAdapter.GetData() select linha;
            foreach (var formaPagamento in obterFormasPagamento)
            {
                lboFormaPagamento.Items.Add(formaPagamento);
            }
        }

        private void LimparElementos()
        {
            cboFormaPagamento.SelectedIndex = -1;
            txtPesquisa.Text = "";
        }

        private void lboFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboFormaPagamento.SelectedItem == null) return;
            Formas_PagamentoRow locacao = lboFormaPagamento.SelectedItem as Formas_PagamentoRow;
            if (locacao == null) return;

            cboFormaPagamento.Text = locacao.tipo;


        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboFormaPagamento.SelectedItem == null) return;
            var pedido = lboFormaPagamento.SelectedItem as Formas_PagamentoRow;
            if (pedido == null) return;

            try
            {
                Formas_PagamentoTableAdapter pedidos = new Formas_PagamentoTableAdapter();
                pedidos.Delete(pedido.id_pagamento);

                LimparElementos();
                atualizarLista();

                MessageBox.Show("Tipo de Pagamento removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboFormaPagamento.SelectedItem == null) return;
            Formas_PagamentoRow locacao = lboFormaPagamento.SelectedItem as Formas_PagamentoRow;
            if (locacao == null) return;

            string tipo = cboFormaPagamento.Text;



            try
            {

                Formas_PagamentoTableAdapter locacoes = new Formas_PagamentoTableAdapter();

                locacoes.Update(locacao.id_pagamento,tipo);


                atualizarLista();
                LimparElementos();

                MessageBox.Show("Tipo de Pagamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Caso aconteça algum erro de banco ou digitação, ele entra aqui
                MessageBox.Show("Erro ao atualizar o Tipo de Pagamento: " + ex.Message, "Erro");
            }
        }



        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            string tipo = cboFormaPagamento.Text;


            try
            {
                Formas_PagamentoTableAdapter locacoes = new Formas_PagamentoTableAdapter();

                locacoes.Insert(tipo);

                LimparElementos();
                atualizarLista();

                MessageBox.Show("Tipo de Pagamento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            TextBox pesquisa = sender as TextBox;

            if (pesquisa.Text == "")
            {
                atualizarLista();
                return;
            }

            lboFormaPagamento.ClearSelected();
            lboFormaPagamento.Items.Clear();

            string textoDigitado = txtPesquisa.Text;


            Formas_PagamentoTableAdapter dados = new Formas_PagamentoTableAdapter();

            var usuarios = from linha in dados.GetData()
                           where linha.tipo.ToLower().Contains(textoDigitado.ToLower())
                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboFormaPagamento.Items.Add(usuario);
            }
        }
    }
}

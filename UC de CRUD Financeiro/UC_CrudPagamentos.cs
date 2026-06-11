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
    public partial class UC_CrudPagamentos : UserControl
    {
        public UC_CrudPagamentos()
        {
            InitializeComponent();

            Formas_PagamentoTableAdapter clientes = new Formas_PagamentoTableAdapter();
            var obterClientes = from linha in clientes.GetData() select linha;

            foreach (var cliente in obterClientes)
            {
                cboFormaPagamento.Items.Add(cliente);
            }
            cboFormaPagamento.SelectedIndex = -1;

            AtualizarLista();
        }

        private void lboPagamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboPagamentos.SelectedItem == null) return;
            PagamentosRow item = lboPagamentos.SelectedItem as PagamentosRow;
            if (item == null) return;

            txtPedido.Text = item.pedido_id.ToString();
            cboFormaPagamento.Text = item.forma_pagamento.ToString();
            dtpDataPagamento.Value = item.data_pagamento;
            cboStatusPagamento.Text = item.acompanhamento.ToString();
            txtValorPago.Text = item.valor_pago.ToString();
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboPagamentos.SelectedItem == null) return;
            var pedido = lboPagamentos.SelectedItem as PagamentosRow;
            if (pedido == null) return;

            try
            {
                PagamentosTableAdapter pedidos = new PagamentosTableAdapter();
                pedidos.Delete(pedido.id_pagamento);

                LimparElementos();
                AtualizarLista();

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
            if (lboPagamentos.SelectedItem == null) return;
            PagamentosRow item = lboPagamentos.SelectedItem as PagamentosRow;
            if (item == null) return;

            txtPedido.Text = item.pedido_id.ToString();
            cboFormaPagamento.Text = item.forma_pagamento_id.ToString();
            dtpDataPagamento.Value = item.data_pagamento;
            cboStatusPagamento.Text = item.acompanhamento.ToString();
            txtValorPago.Text = item.valor_pago.ToString();
        


            try
            {
                PagamentosTableAdapter servicos = new PagamentosTableAdapter();
                servicos.Update(item.id_pagamento,item.pedido_id,item.forma_pagamento_id, item.data_pagamento, item.valor_pago, item.acompanhamento);

                LimparElementos();
                AtualizarLista();
                MessageBox.Show("Pagamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                AtualizarLista();
                return;
            }

            lboPagamentos.ClearSelected();
            lboPagamentos.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            PagamentosTableAdapter dados = new PagamentosTableAdapter();

            var itensFiltrados = from linha in dados.GetData()
                                 where linha.pedido_id.ToString().Contains(textoDigitado.ToLower())
                                 select linha;

            foreach (var item in itensFiltrados)
            {
                lboPagamentos.Items.Add(item);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            int pagamentoId = cboFormaPagamento.SelectedIndex;;
            int pedidoId = int.Parse(txtPedido.Text);
            DateTime dataTransacao = dtpDataPagamento.Value;
            decimal valorPago = decimal.Parse(txtValorPago.Text);
            string acompanhamento = cboStatusPagamento.Text;

            try
            {
                PagamentosTableAdapter locacoes = new PagamentosTableAdapter();

                locacoes.Insert(pedidoId,pagamentoId,dataTransacao, valorPago, acompanhamento);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Pagamento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void AtualizarLista()
        {
            lboPagamentos.Items.Clear();
            PagamentosTableAdapter servicos = new PagamentosTableAdapter();
            var dados = from linha in servicos.GetData()
                        select linha;
            foreach (PagamentosRow dado in dados) lboPagamentos.Items.Add(dado);
        }



        private void LimparElementos()
        {
            cboFormaPagamento.SelectedIndex = -1;
            cboStatusPagamento.SelectedIndex = -1;
            txtPedido.Text = "";
            txtValorPago.Text = "";
            dtpDataPagamento.Value = DateTime.Now;

        }
    }
}

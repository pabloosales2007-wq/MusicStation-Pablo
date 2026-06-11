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
    public partial class UC_CrudTranPagamentos : UserControl
    {
        public UC_CrudTranPagamentos()
        {
            InitializeComponent();
            atualizarLista();
        }

        private void lboTranPagamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboTranPagamentos.SelectedItem == null) return;
            Transacoes_PagamentoRow locacao = lboTranPagamentos.SelectedItem as Transacoes_PagamentoRow;
            if (locacao == null) return;

            cboStatusTransacao.Text = locacao.acompanhamento;
            cboStatusTransacao.Text = locacao.acompanhamento;
            dtpDataTransacao.Value = locacao.data_transacao;
            txtCodigoExterno.Text = locacao.codigo_externo;

            lblPagamentoRef.Text = $"Pagamento: {locacao.id_transacao}";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            TextBox pesquisa = sender as TextBox;

            if (pesquisa.Text == "")
            {
                atualizarLista();
                return;
            }

            lboTranPagamentos.ClearSelected();
            lboTranPagamentos.Items.Clear();

            string textoDigitado = txtPesquisa.Text;


            Transacoes_PagamentoTableAdapter dados = new Transacoes_PagamentoTableAdapter();

            var usuarios = from linha in dados.GetData()
                           where linha.codigo_externo.ToLower().Contains(textoDigitado.ToLower())

                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboTranPagamentos.Items.Add(usuario);
            }
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboTranPagamentos.SelectedItem == null) return;
            Transacoes_PagamentoRow locacao = lboTranPagamentos.SelectedItem as Transacoes_PagamentoRow;
            if (locacao == null) return;

            int pagamentoId = cboPagamentos.SelectedIndex;
            string Acompanhamento = cboStatusTransacao.Text;
            string CodigoExterno = txtCodigoExterno.Text;
            DateTime dateTime = dtpDataTransacao.Value;


            try
            {
                Transacoes_PagamentoTableAdapter servicos = new Transacoes_PagamentoTableAdapter();
                servicos.Update(locacao.id_transacao, locacao.pagamento_id, locacao.acompanhamento, CodigoExterno, dateTime);

                LimparElementos();
                atualizarLista();
                MessageBox.Show("Locação de Item atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            int pagamentoId = cboPagamentos.SelectedIndex;
            string Acompanhamento = cboStatusTransacao.Text;
            string CodigoExterno = txtCodigoExterno.Text;
            DateTime dateTime = dtpDataTransacao.Value;

            try
            {
                Transacoes_PagamentoTableAdapter locacoes = new Transacoes_PagamentoTableAdapter();

                locacoes.Insert(pagamentoId, Acompanhamento, CodigoExterno, dateTime);

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

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboTranPagamentos.SelectedItem == null) return;
            var pedido = lboTranPagamentos.SelectedItem as Transacoes_PagamentoRow;
            if (pedido == null) return;

            try
            {
                Transacoes_PagamentoTableAdapter pedidos = new Transacoes_PagamentoTableAdapter();
                pedidos.Delete(pedido.id_transacao);

                LimparElementos();
                atualizarLista();

                MessageBox.Show("Transação de Pagamento removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void atualizarLista()
        {
            lboTranPagamentos.ClearSelected();
            lboTranPagamentos.Items.Clear();
            Transacoes_PagamentoTableAdapter formasPagamentoAdapter = new Transacoes_PagamentoTableAdapter();
            var obterFormasPagamento = from linha in formasPagamentoAdapter.GetData() select linha;
            foreach (var formaPagamento in obterFormasPagamento)
            {
                lboTranPagamentos.Items.Add(formaPagamento);
            }
        }

        private void LimparElementos()
        {
            lblPagamentoRef.Text = "";
            cboStatusTransacao.SelectedIndex = 0;
            dtpDataTransacao.Value = DateTime.Now;
            txtCodigoExterno.Text = "";
            
        }
    }
}

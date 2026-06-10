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
    public partial class UC_CrudLocacoesItens : UserControl
    {
        public UC_CrudLocacoesItens()
        {
            InitializeComponent();

            InstrumentosTableAdapter instrumentosAdapter = new InstrumentosTableAdapter();
            var obterInstrumentos = from linha in instrumentosAdapter.GetData() select linha;
            foreach (var instrumento in obterInstrumentos)
            {
                cboInstrumento.Items.Add(instrumento);
            }
            cboInstrumento.SelectedIndex = -1;

            LocacoesTableAdapter LocacoesAdapter= new LocacoesTableAdapter();
            var obterLocacoes = from linha in LocacoesAdapter.GetData() select linha;
            foreach (var locacao in obterLocacoes)
            {
                cboLocacao.Items.Add(locacao);
            }
            cboLocacao.SelectedIndex = -1;


            AtualizarLista();
        }

        private void lboLocacoesItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboLocacoesItens.SelectedItem == null) return;
            Locacao_ItensRow item = lboLocacoesItens.SelectedItem as Locacao_ItensRow;
            if (item == null) return;

            txtPrecoLocacao.Text = item.preco_locacao.ToString("F2");
            txtDias.Text = item.dias.ToString();
            txtSubtotal.Text = item.subtotal.ToString("F2");
            cboInstrumento.Text = item.NomeInstrumento;

            lblNomeLocacao.Text = $"N° da Locação:  {item.locacao_id} ";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            TextBox pesquisa = sender as TextBox;

            if (pesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }

            lboLocacoesItens.ClearSelected();
            lboLocacoesItens.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            Locacao_ItensTableAdapter dados = new Locacao_ItensTableAdapter();

            var itensFiltrados = from linha in dados.GetData()
                                 where linha.NomeInstrumento.ToLower().Contains(textoDigitado.ToLower())
                                    || linha.locacao_id.ToString().Contains(textoDigitado.ToLower())
                                 select linha;

            foreach (var item in itensFiltrados)
            {
                lboLocacoesItens.Items.Add(item);
            }
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboLocacoesItens.SelectedItem == null) return;
            Locacao_ItensRow locacao = lboLocacoesItens.SelectedItem as Locacao_ItensRow;
            if (locacao == null) return;

            InstrumentosRow instrumento = cboInstrumento.SelectedItem as InstrumentosRow;

            if (instrumento == null)
            {
                MessageBox.Show("Selecione um instrumento.");
                return;
            }

            int instrumentoId = instrumento.id_instrumento;

            decimal precoLocacao = decimal.Parse(txtPrecoLocacao.Text);
            int dias = int.Parse(txtDias.Text);
            decimal subtotal = decimal.Parse(txtSubtotal.Text);


            try
            {
                Locacao_ItensTableAdapter servicos = new Locacao_ItensTableAdapter();
                servicos.Update(locacao.id_item,locacao.locacao_id, locacao.instrumento_id, precoLocacao,dias,subtotal);

                LimparElementos();
                AtualizarLista();
                MessageBox.Show("Locação de Item atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            LocacoesRow locacao = cboLocacao.SelectedItem as LocacoesRow;
            InstrumentosRow instrumento = cboInstrumento.SelectedItem as InstrumentosRow;

            if (locacao == null || instrumento == null)
            {
                MessageBox.Show("Selecione uma locação e um instrumento.");
                return;
            }

            int locacaoId = locacao.id_locacao;
            int instrumentoId = instrumento.id_instrumento;

            decimal precoLocacao = decimal.Parse(txtPrecoLocacao.Text);
            int dias = int.Parse(txtDias.Text);
            decimal subtotal = decimal.Parse(txtSubtotal.Text);


            try
            {
                Locacao_ItensTableAdapter pedidos = new Locacao_ItensTableAdapter();
                pedidos.Insert(locacaoId,instrumentoId,precoLocacao,dias,subtotal);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Locação de Item cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboLocacoesItens.SelectedItem == null) return;
            var pedido = lboLocacoesItens.SelectedItem as Locacao_ItensRow;
            if (pedido == null) return;

            try
            {
                Locacao_ItensTableAdapter pedidos = new Locacao_ItensTableAdapter();
                pedidos.Delete(pedido.id_item);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Item removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void AtualizarLista()
        {
            lboLocacoesItens.Items.Clear();
            Locacao_ItensTableAdapter servicos = new Locacao_ItensTableAdapter();
            var dados = from linha in servicos.GetData()
                        select linha;
            foreach (Locacao_ItensRow dado in dados) lboLocacoesItens.Items.Add(dado);

        }



        private void LimparElementos()
        {
            txtDias.Clear();
            cboInstrumento.Text = "";
            lboLocacoesItens.Text = "N° da Locação:";
            txtPesquisa.Clear();
            txtSubtotal.Clear();
            txtPrecoLocacao.Clear();

        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecoLocacao.Text, out decimal preco) && int.TryParse(txtDias.Text, out int dias))
            {
                txtSubtotal.Text = (preco * dias).ToString("F2");
            }
            else
            {
                txtSubtotal.Text = "0,00";
            }
        }
    }
}

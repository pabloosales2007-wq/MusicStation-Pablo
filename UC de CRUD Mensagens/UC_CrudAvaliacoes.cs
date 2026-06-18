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
    public partial class UC_CrudAvaliacoes : UserControl
    {
        public UC_CrudAvaliacoes()
        {
            InitializeComponent();



            AtualizarLista();
        }

        private void lboAvaliacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboAvaliacoes.SelectedItem == null) return;
            AvaliacoesRow avaliacao = lboAvaliacoes.SelectedItem as AvaliacoesRow;
            if (avaliacao == null) return;

            cboServicoPedido.SelectedValue = avaliacao.servico_pedido_id;
            cboCliente.SelectedValue = avaliacao.cliente_id;
            cboNota.SelectedItem = avaliacao.nota;
            txtComentario.Text = avaliacao.comentario;
            dtpDataAvaliacao.Value = avaliacao.data_avaliacao;
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboAvaliacoes.SelectedItem == null) return;
            AvaliacoesRow avaliacao = lboAvaliacoes.SelectedItem as AvaliacoesRow;
            if (avaliacao == null) return;

            AvaliacoesTableAdapter avaliacoes = new AvaliacoesTableAdapter();
            avaliacoes.Delete(avaliacao.id_avaliacao);
            LimparElementos();
            AtualizarLista();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparElementos();
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboAvaliacoes.SelectedItem == null) return;
            AvaliacoesRow avaliacao = lboAvaliacoes.SelectedItem as AvaliacoesRow;
            if (avaliacao == null) return;

            int servico_pedido_id = (int)cboServicoPedido.SelectedValue;
            int cliente_id = (int)cboCliente.SelectedValue;
            int nota = (int)cboNota.SelectedItem;
            string comentario = txtComentario.Text;
            DateTime data = dtpDataAvaliacao.Value;

            try
            {
                AvaliacoesTableAdapter adapter = new AvaliacoesTableAdapter();
                adapter.Update(avaliacao.id_avaliacao, servico_pedido_id, cliente_id, nota, comentario, data);
                LimparElementos();
                AtualizarLista();
                MessageBox.Show("Avaliação atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            int servico_pedido_id = (int)cboServicoPedido.SelectedValue;
            int cliente_id = (int)cboCliente.SelectedValue;
            int nota = (int)cboNota.SelectedItem;
            string comentario = txtComentario.Text;
            DateTime data = dtpDataAvaliacao.Value;

            try
            {
                AvaliacoesTableAdapter adapter = new AvaliacoesTableAdapter();
                adapter.Insert(servico_pedido_id, cliente_id, nota, comentario, data);
                LimparElementos();
                AtualizarLista();
                MessageBox.Show("Avaliação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // Filtra a ListBox em tempo real conforme o usuário digita o nome ou email
            TextBox pesquisa = sender as TextBox;

            if (pesquisa.Text == "")
            {
                AtualizarLista(); // Recarrega todos os usuários se o campo estiver vazio
                return;
            }

            lboAvaliacoes.ClearSelected();
            lboAvaliacoes.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            // Instancia o adaptador de usuários do seu projeto
            AvaliacoesTableAdapter dados = new AvaliacoesTableAdapter();

            // Faz a busca usando LINQ (procura tanto no Nome quanto no Email)
            var usuarios = from linha in dados.GetData()
                           where linha.NomeCliente.ToLower().Contains(textoDigitado.ToLower())
                           || linha.comentario.ToLower().Contains(textoDigitado.ToLower())

                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboAvaliacoes.Items.Add(usuario);
            }
        }


        private void LimparElementos()
        {
            cboServicoPedido.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            cboNota.SelectedIndex = -1;
            txtComentario.Clear();
            dtpDataAvaliacao.Value = DateTime.Now;


        }

        private void AtualizarLista()
        {
            lboAvaliacoes.Items.Clear();
            AvaliacoesTableAdapter adapter = new AvaliacoesTableAdapter();
            var dados = from linha in adapter.GetData() select linha;
            foreach (AvaliacoesRow dado in dados)
            lboAvaliacoes.Items.Add(dado);
        }
    }
}

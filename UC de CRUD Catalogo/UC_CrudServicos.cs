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
    public partial class UC_CrudServicos : UserControl
    {
        public UC_CrudServicos()
        {
            InitializeComponent();
            AtualizarLista();
        }

        private void lboServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboServicos.SelectedItem == null) return;
            var servico = lboServicos.SelectedItem as ServicosRow;
            if (servico == null) return;

            txtNome.Text = servico.nome;
            txtDescricao.Text = servico.descricao;
            txtPreco.Text = servico.preco.ToString("F2");
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            decimal preco = decimal.Parse(txtPreco.Text);

            try
            {
                ServicosTableAdapter servicos = new ServicosTableAdapter();
                servicos.Insert(nome, descricao, preco);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Serviço cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboServicos.SelectedItem == null) return;
            var servico = lboServicos.SelectedItem as ServicosRow;
            if (servico == null) return;

            int idServico = servico.id_servico;
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            decimal preco = decimal.Parse(txtPreco.Text);

            try
            {
                ServicosTableAdapter servicos = new ServicosTableAdapter();
                servicos.Update(idServico, nome, descricao, preco);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Serviço atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboServicos.SelectedItem == null) return;
            var servico = lboServicos.SelectedItem as ServicosRow;
            if (servico == null) return;

            try
            {
                ServicosTableAdapter servicos = new ServicosTableAdapter();
                servicos.Delete(servico.id_servico);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Serviço removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }


        private void AtualizarLista()
        {
            lboServicos.Items.Clear();
            ServicosTableAdapter servicos = new ServicosTableAdapter();
            var dados = from linha in servicos.GetData()
                        select linha;
            foreach (ServicosRow dado in dados) lboServicos.Items.Add(dado);

        }

        private void LimparElementos()
        {
            txtNome.Clear();
            txtPesquisa.Clear();
            txtDescricao.Clear();
            txtPreco.Clear(); 
        }
    }
}

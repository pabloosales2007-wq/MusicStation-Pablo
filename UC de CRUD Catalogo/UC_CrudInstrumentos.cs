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
    public partial class UC_CrudInstrumentos : UserControl
    {
        public UC_CrudInstrumentos()
        {
            InitializeComponent();

            EmpresasTableAdapter empresas = new EmpresasTableAdapter();
            var obterEmpresas = from linha in empresas.GetData() select linha;
            foreach (var empresa in obterEmpresas) cboEmpresa.Items.Add(empresa);
            cboEmpresa.SelectedIndex = -1;


            AtualizarLista();
        }

        private void lboInstrumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboInstrumentos.SelectedItem == null) return;
            InstrumentosRow instrumento = lboInstrumentos.SelectedItem as InstrumentosRow;
            if (instrumento == null) return;

            txtNome.Text = instrumento.nome;
            txtDescricao.Text = instrumento.descricao;
            txtPrecoLocacao.Text = instrumento.preco_locacao.ToString("F2");
            chkDisponivel.Checked = instrumento.disponivel;
            cboEmpresa.SelectedValue = instrumento.empresa_id;
        }

        private void btnDeletarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboInstrumentos.SelectedItem == null) return;
            var instrumento = lboInstrumentos.SelectedItem as InstrumentosRow;
            if (instrumento == null) return;

            try
            {
                InstrumentosTableAdapter instrumentos = new InstrumentosTableAdapter();
                instrumentos.Delete(instrumento.id_instrumento);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Instrumento removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void btnAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            if (lboInstrumentos.SelectedItem == null) return;
            var instrumento = lboInstrumentos.SelectedItem as InstrumentosRow;
            var empresaSelecionada = cboEmpresa.SelectedItem as EmpresasRow;
            if (instrumento == null || empresaSelecionada == null) return;

            int idInstrumento = instrumento.id_instrumento;
            int idEmpresa = empresaSelecionada.id_empresa;
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            decimal preco = decimal.Parse(txtPrecoLocacao.Text);
            bool disponivel = chkDisponivel.Checked;

            try
            {
                InstrumentosTableAdapter instrumentos = new InstrumentosTableAdapter();
                instrumentos.Update(idInstrumento, idEmpresa, nome, descricao, preco, disponivel);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Instrumento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Filtra a ListBox em tempo real conforme o usuário digita o nome ou email
            TextBox pesquisa = sender as TextBox;

            if (pesquisa.Text == "")
            {
                AtualizarLista(); // Recarrega todos os usuários se o campo estiver vazio
                return;
            }

            lboInstrumentos.ClearSelected();
            lboInstrumentos.Items.Clear();

            string textoDigitado = txtPesquisa.Text;

            // Instancia o adaptador de usuários do seu projeto
            InstrumentosTableAdapter dados = new InstrumentosTableAdapter();

            // Faz a busca usando LINQ (procura tanto no Nome quanto no Email)
            var usuarios = from linha in dados.GetData()
                           where linha.NomeEmpresa.ToLower().Contains(textoDigitado.ToLower())

                           select linha;

            // Adiciona os usuários filtrados na sua ListBox de usuários
            foreach (var usuario in usuarios)
            {
                lboInstrumentos.Items.Add(usuario);
            }
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            var empresaSelecionada = cboEmpresa.SelectedItem as EmpresasRow;
            if (empresaSelecionada == null) return;

            int idEmpresa = empresaSelecionada.id_empresa;
            string nome = txtNome.Text;
            string descricao = txtDescricao.Text;
            decimal preco = decimal.Parse(txtPrecoLocacao.Text);
            bool disponivel = chkDisponivel.Checked;

            try
            {
                InstrumentosTableAdapter instrumentos = new InstrumentosTableAdapter();
                instrumentos.Insert(idEmpresa, nome, descricao, preco, disponivel);

                LimparElementos();
                AtualizarLista();

                MessageBox.Show("Instrumento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void AtualizarLista()
        {
            lboInstrumentos.Items.Clear();
            InstrumentosTableAdapter empresas = new InstrumentosTableAdapter();
            var dados = from linha in empresas.GetData()
                        select linha;
            foreach (InstrumentosRow dado in dados) lboInstrumentos.Items.Add(dado);

        }

        private void LimparElementos()
        {
            txtNome.Clear();
            txtPesquisa.Clear();
            txtDescricao.Clear();
            txtPrecoLocacao.Clear();
            cboEmpresa.Text = "";
            chkDisponivel.Checked = false;


        }
    }
}
